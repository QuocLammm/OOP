using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.TextCore.Text;
using Unity.VisualScripting;

public class Enemy1 : MonoBehaviour
{
    public bool roaming = false; //cho phep bam theo hoac di vong tron
    public float moveSpeed = 2f;
    public float nextWayPointDistance = 2f;
    bool reachDestination = false;
    public bool updateContinuesPath = true;
    public float followPlayerRange;
    public SpriteRenderer character;

    public Seeker seeker;
    Path path;
    Coroutine moveCoroutine;
    

    //shot
    public bool isShootable = false; // cho phep ban
    public GameObject bullet;
    public float bulletSpeed; // toc do dan ra
    public float timeBwFire; // thoi gian ra dan
    private float fireCoolDown; //  thoi gian giua cac vien dan
    public Transform bulletPos;//vi tri spawm vien dan
    public float attackRange; //Khoảng cách được tấn công


    public float freezeDurationTime;
    float freezeDuration;

    //dame
    Health PlayerHealth;
    public int minDamage;
    public int maxDamage;


    private void Start()
    {
        InvokeRepeating("Calculate", 0f, 0.5f);
        reachDestination = true;
    }

    private void Update()
    {
        fireCoolDown -= Time.deltaTime;
        Vector3 playerPos = FindObjectOfType<Player>().transform.position;
        if (fireCoolDown < 0 && isShootable == true && (Vector3.Distance(transform.position,playerPos) <= attackRange)) // nếu như vị trí của nhân vật vào trong tầm đánh thì bắn đạn
        {
            fireCoolDown = timeBwFire;
            //shoot
            EnemyFireBullet();
        }
    }

    void EnemyFireBullet()
    {
        var bulletbwp = Instantiate(bullet, bulletPos.position, Quaternion.identity);

        Rigidbody2D rb = bulletbwp.GetComponent<Rigidbody2D>();
        Vector3 playerPos = FindObjectOfType<Player>().transform.position;
        Vector3 direction = playerPos - transform.position;
        rb.AddForce(direction.normalized * bulletSpeed, ForceMode2D.Impulse);
    }

    void Calculate()
    {
        Vector2 target = FindTarget();

        if (seeker.IsDone() && (reachDestination || updateContinuesPath))
        {
            seeker.StartPath(transform.position, target, OnPath);
        }
    }

    void OnPath(Path p)
    {
        if(p.error) { return; }
        path = p;
        //move to target
        MoveToTarget();
    }

    void MoveToTarget()
    {
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);
        moveCoroutine = StartCoroutine(MoveToTargetCoroutine());
    }

    IEnumerator MoveToTargetCoroutine()
    {
        int currentWP = 0;
        reachDestination = false;

        while (currentWP < path.vectorPath.Count)
        {
            while (freezeDuration > 0)
            {
                freezeDuration -= Time.deltaTime;
                yield return null;
            }
            Vector2 direction = ((Vector2)path.vectorPath[currentWP] - (Vector2)transform.position).normalized;
            Vector2 force = direction * moveSpeed * Time.deltaTime;
            transform.position += (Vector3)force; //them luc cho dan
            float distance = Vector2.Distance(transform.position, path.vectorPath[currentWP]);
            if (distance < nextWayPointDistance)
                currentWP++;
            // thay đổi hướng
            if (force.x != 0)
                if (force.x < 0)
                    character.transform.localScale = new Vector3(-1, 1, 0);
                else
                    character.transform.localScale = new Vector3(1, 1, 0);
            yield return null;
        }
        reachDestination = false;
    }

    Vector2 FindTarget()
    {
        Vector3 playerPos = FindObjectOfType<Player>().transform.position;
        if(roaming == true)
        {
            return (Vector2)playerPos + (Random.Range(5f, followPlayerRange) * new Vector2(Random.Range(-1,1), Random.Range(-1, 1)).normalized);
        }
        else
        {
            return playerPos;
        }
    }

    public void FreezeEnemy()
    {
        freezeDuration = freezeDurationTime;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth = collision.gameObject.GetComponent<Health>();
            InvokeRepeating("DamagePlayer", 0, 1f);
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Player"))
        {
            CancelInvoke("DamagePlayer");
            PlayerHealth = null;
        }
    }

    void DamagePlayer()
    {
        if(PlayerHealth != null)
        {
            int damage = Random.Range(minDamage, maxDamage);
            PlayerHealth.TakeDam(damage);
            PlayerHealth.GetComponent<Player>().TakeDamageEffect(damage);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}



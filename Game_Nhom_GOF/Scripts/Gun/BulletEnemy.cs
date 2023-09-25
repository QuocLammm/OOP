using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class BulletEnemy : MonoBehaviour
{
    public int minDamage = 2;
    public int maxDamage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int damage = Random.Range(minDamage, maxDamage);
            collision.GetComponent<Health>().TakeDam(damage); //gây mất máu
            collision.GetComponent<PlayerController1>().TakeDamEffect(damage); //hiện số dame
            collision.GetComponent<Player>().TakeDamageEffect(damage); // player nhận dame thực takedamegeEffect -> losepanet
            Destroy(gameObject); //xóa đạn khi va chạm
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int minDamage = 2;
    public int maxDamage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            int damage = Random.Range(minDamage, maxDamage);
            collision.GetComponent<Health>().TakeDam(damage);
            collision.GetComponent<EnemyController>().TakeDamEffect(damage);
        }
    }
}

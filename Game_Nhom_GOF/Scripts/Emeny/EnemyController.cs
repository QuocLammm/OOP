using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject damPopUp;
    Health health;
    ColoredFlash flash;
    Enemy1 enemyAI;


    private void Start()
    {
        health = GetComponent<Health>();
        flash = GetComponent<ColoredFlash>();
        enemyAI = GetComponent<Enemy1>();
    }

    public void TakeDamEffect(int damage)
    {
        if (damPopUp != null)
        {
            GameObject instance = Instantiate(damPopUp, transform.position 
                + new Vector3(UnityEngine.Random.Range(-0.3f, 0.3f), 0.5f, 0), Quaternion.identity);
            instance.GetComponentInChildren<TextMeshProUGUI>().text = damage.ToString();
            Animator animator = instance.GetComponentInChildren<Animator>();
            if (damage <= 3) animator.Play("normal");
            else animator.Play("critical");
        }

        // Flash
        if (flash != null)
        {
            flash.Flash(Color.white);
        }
        // Freeze
        if (enemyAI != null)
        {
            enemyAI.FreezeEnemy();
        }
    }
}

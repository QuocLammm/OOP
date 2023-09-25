using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    int currentHealth;

    public HealthBar healthBar;

    public bool IsDead = false;

    //máu ban đàu
    private void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
            healthBar.UpdateHealth(currentHealth, maxHealth);
    }
    //mát máu khi dính dame quái
    public void TakeDam(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) //health == 1 thì Player == Dead
        {
            currentHealth = 0;
            if (this.gameObject.tag == "Monster") // khi gameOject = tag<Monster> 
            {
                Destroy(this.gameObject, 0.1f);
                FindObjectOfType<Killed>().UpdateKilled(); // kill++
                AudioManage.instance.PlaySFX("Hit");
            }
            IsDead = true;
        }
        // If player then update health bar
        if (healthBar != null)
            healthBar.UpdateHealth(currentHealth, maxHealth);
    }
}

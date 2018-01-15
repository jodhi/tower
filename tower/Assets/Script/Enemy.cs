using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector]
    public float speed;

    public float health;
    public float starthealth = 100;
    public int moneyGain = 50;

    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    private void Start()
    {
        starthealth += PlayerStats.Rounds * 10;
        Debug.Log(starthealth);
        speed = startSpeed;
        health = starthealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        

        if (health <= 0)
        {
            Die();
        }
        healthBar.fillAmount = health / starthealth;
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        PlayerStats.Money += moneyGain;
        
        Destroy(gameObject);
    }


}  

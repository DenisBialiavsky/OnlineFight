using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float healthEnemy = 1.0f;
    private float dmg = 0.3f;

    public GameObject deathEffect;

    public void TakeDamage(float dmg)
    {
        //HealthBar healthbar = GetComponent<HealthBar>();
        healthEnemy -= dmg;
        //healthbar.SetHealthBarValue(healthbar.GetHealthBarValue() - dmg);

        if (healthEnemy <= 0)
        {
            Debug.Log("Die");
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

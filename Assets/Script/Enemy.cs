using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyhealth = 1;


    public void TakeDamage(int damage)
    {
        enemyhealth -= damage;

        if (enemyhealth <= 0)
        {
            Die();
        } 
    }

    void Die()
    {
        ScoreScript.scoreValue += 1;
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;

    Player target;

    public float speed;
    public GameObject enemy;
    public int health = 9;


    public void TakeDamage(int damage)
    {
        health = -damage;

        if (health < 1)
        {
            Die();
        }
    }

    void Die() 
    {
        Destroy(gameObject);
    }
    
}

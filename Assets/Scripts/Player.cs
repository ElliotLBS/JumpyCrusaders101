using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    public int health;
    float speed = 2;

    public int playerhealth;

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
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    Transform destination;
    public Transform target;
    public float speed;
    public GameObject enemy;
    public int health = 9;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.transform.name);
        if (collision.transform.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            //collision.transform.position = destination.position;
            PlayerScript.hasKey = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
   
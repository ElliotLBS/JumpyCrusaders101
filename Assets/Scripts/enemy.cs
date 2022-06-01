using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    public int moveSpeed = 1;
    public GameObject enemy;
    public int health = 9;
    Vector3 computerDirection = Vector3.left;
    Vector3 moveDirection = Vector3.zero;
    Vector3 newPosition = Vector3.zero;
    [SerializeField]
    Transform destination;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.transform.name);
        if (collision.transform.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            PlayerScript.hasKey = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void Update()
    {
        Vector3 newPosition = computerDirection * (moveSpeed * Time.deltaTime);
        newPosition = transform.position + newPosition;
        newPosition.x = Mathf.Clamp(newPosition.x, -101, 126);
        transform.position = newPosition;

        if (Physics2D.Raycast(transform.position - transform.right, Vector3.down) == false)
        {
            computerDirection.x = 1;
        }

        if (Physics2D.Raycast(transform.position + transform.right, Vector3.down) == false)
        {
            computerDirection.x = 1;
        }


        if (newPosition.x > 126)
        {
            newPosition.x = 126;
            computerDirection.x *= -1;
        }
        else if (newPosition.x < -101)
        {
            newPosition.x = -101;
            computerDirection.x *= -1;
        }

    }

}

   
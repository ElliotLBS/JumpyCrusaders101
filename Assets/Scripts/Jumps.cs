using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumps : MonoBehaviour
{
    //gjord av Simon (skriptet)
    //detta skript �r mer f�r att checka plattformarna s� vi kan ta anv�ndning av platformeffector 2d �n f�r att hoppa -Simon

    #region Variables
    public bool startTimer;
    bool isGrounded;
    public LayerMask mask;

    Rigidbody2D rb;
    BoxCollider2D boxCollider2D;

    [SerializeField]
    float moveSpeed;

    [SerializeField]
    float jumpPower;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region References
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        #region PlatformCheck
        /*RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, 5f, mask);
        Debug.DrawRay(transform.position, -transform.up, Color.black, 5f);*/

        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size - new Vector3(0.1f, 0, 0), 0, -transform.up, 0.1f, mask); 
        //skapar en boxcast i formen av spelarens boxcollider, men lite under spelaren f�r att checka om spelaren �r p� marken eller ej. den �r lite kortare p� h�ger och v�nster sida f�r att den inte ska bugga och detecta "ground" som v�gg. -Simon

        if (hit.transform != null) //om boxcasten tr�ffar n�gonting s� startas timern f�r plattformarna och man �r "isgrounded" vilket betyder att man kan hoppa igen -Simon
        {
            startTimer = true;
            isGrounded = true;
        }
        else //om den inte tr�ffar n�got s� st�ngs timern av och man �r inte grounded = inga hopp. -Simon
        {
            startTimer = false;
            isGrounded = false;
        }

        #endregion

        #region Jump
        if (isGrounded && Input.GetButtonDown("Jump")) //om man �r p� marken och trycker p� "Jump" knappen vilket defaultar till spacebar, s� hoppar man -Simon
        {
            rb.AddForce(transform.up * jumpPower);
        }
        #endregion

        



    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTaker : MonoBehaviour
{
    public int coinAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Gjord av Simon
        #region Coin
        if (collision.tag == "Coin") //om man kolliderar med nyckeln (trigger) s� blir "hasKey" true
        {
            coinAmount += 1;
            Destroy(collision.transform.gameObject);
            print("Got Coin!");
        }
        #endregion
    }
}

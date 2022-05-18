using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinTaker.hasCoin) //om du har nyckeln, så försvinner väggen som blockerar slutet
        {
            gameObject.SetActive(false);
        }
    }
}

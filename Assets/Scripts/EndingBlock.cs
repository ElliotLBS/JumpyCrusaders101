using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingBlock : MonoBehaviour
{
    //skriven av Simon
    void Update()
    {
        if (PlayerScript.hasKey) //om du har nyckeln, s� f�rsvinner v�ggen som blockerar slutet
        {
            gameObject.SetActive(false);
        }
    }
}

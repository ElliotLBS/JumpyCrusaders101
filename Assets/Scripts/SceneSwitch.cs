using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    //gjord av Simon
    private void OnTriggerEnter2D(Collider2D collision) //n�r man nuddar ett specifikt block s� byter man till n�sta scen (slutet)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);

    }
}

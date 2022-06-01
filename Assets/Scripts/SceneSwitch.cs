using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int sceneIndex;
    //gjord av Simon
    private void OnTriggerEnter2D(Collider2D collision) //när man nuddar ett specifikt block så byter man till nästa scen (slutet)
    {
        print("byter scen");
        SceneManager.LoadScene(sceneIndex);

    }
}

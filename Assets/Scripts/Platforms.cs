using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Gjord av Simon
public class Platforms : MonoBehaviour
{ //variabler
    private PlatformEffector2D effector;
    public float waitTime;

    public PlayerScript PlayerScript;

    void Start()
    { //referenser till components
        effector = GetComponent<PlatformEffector2D>();
        PlayerScript = PlayerScript.GetComponent<PlayerScript>();
    }

    
    void Update()
    {
        if (PlayerScript.startTimer) //om "startTimer" �r true, s� startas timern h�r
        {
            waitTime -= Time.deltaTime;
        }
        if (!PlayerScript.startTimer) //om "startTimer" �r false, s� s�tts timern till 3 sekunder
        {
            waitTime = 3;
        }
        
        if(waitTime <= 0) //om timern �r mindre �n 0 sekunder (du har st�tt p� plattformen i 3 sekunder), d� �r platformeffectorn riktad ner�t s� du faller igenom plattformen
        {
            effector.rotationalOffset = 170f;
            waitTime = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space)) //n�r man trycker p� space s� roteras platformeffectorn upp�t s� du kan hoppa igenom plattformen underifr�n
        {
            effector.rotationalOffset = 0f;
        }

        if(waitTime > 0 && waitTime < 2.6f) //om timern �r �ver 0 men under 2,6 sekunder s� �r platformeffectorn riktad upp�t s� du kan st� p� den
        {
            effector.rotationalOffset = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
     //gjord av Simon
    public void YesQuit() //funktion f�r att avsluta spelet n�r man trycker p� quit knappen i menyn
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

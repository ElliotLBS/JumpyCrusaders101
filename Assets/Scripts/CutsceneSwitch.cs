using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Gjord av Simon
public class CutsceneSwitch : MonoBehaviour
{

    public void NextCutscene() //knapp f�r att byta till n�sta scen i cutscenes
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SkipCutscene() //knapp f�r att hoppa �ver cutscene och b�rja spela
    {
        SceneManager.LoadScene("Sahan Platform");
    }

    public void SkipEndCutscene() //knapp f�r att hoppa �ver sista cutscenen
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void BackToMenu() //knapp f�r att komma tillbaka till menyn
    {
        SceneManager.LoadScene(0);
    }

}
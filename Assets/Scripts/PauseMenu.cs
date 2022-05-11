using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Gjord av Simon
public class PauseMenu : MonoBehaviour
{ //variabler
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //om man trycker p� escape...
        {
            if (GameIsPaused) //... och spelet �r pausat, d� startas det igen
            {
                Resume();
            }
            else //... och spelet k�rs, d� pausas det
            {
                Pause();
            }
        }
    }
    public void Resume() //�teruppta spelet funktionen
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() //paus funktionen
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() //funktion f�r att g� tillbaka till start menyn
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}

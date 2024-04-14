using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject Menu_;
    public GameObject Exit_;


    
    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void CancelGame()
    {
        SceneManager.LoadScene(0);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    //----------

    public void ExitReady()
    {
        Menu_.SetActive(false);
        Exit_.SetActive(true);
    }
    public void Nope()
    {
        Menu_.SetActive(true);
        Exit_.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

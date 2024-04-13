using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject Menu_;
    public GameObject Settings_;


    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void CancelGame()
    {
        SceneManager.LoadScene(0);
    }

    //----------

    public void Settings()
    {
        Menu_.SetActive(false);
        Settings_.SetActive(true);
    }
    public void SettingsExit()
    {
        Menu_.SetActive(true);
        Settings_.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

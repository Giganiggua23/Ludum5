using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonController : MonoBehaviour
{
    public GameObject Game;
    public GameObject emptyWindow;

    public void OnButtonClick()
    {
        Game.SetActive(false);
        emptyWindow.SetActive(true);
    }
    public void OnButtonSecond()
    {
        Game.SetActive(true);
        emptyWindow.SetActive(false);
    }
}
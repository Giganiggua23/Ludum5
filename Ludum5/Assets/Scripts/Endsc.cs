using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Endsc : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;

    public GameObject butt;

    public TMP_Text chat;

    
    public void End()
    {
        if (first.activeSelf == true && second.activeSelf == true && third.activeSelf == true)
        {
            chat.text = "After receiving the information, the detective learned that the price for a successful connection with the other world was his life.";
        }
        else
        {
            chat.text = "Having not received the necessary information, the detective stops cooperating with the organization.";
        }
        butt.SetActive (false);
    }
   
    
}



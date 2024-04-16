using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class yea : MonoBehaviour
{
    public GameObject NextTextt;
    public GameObject yeas;
    public GameObject choess;

    public TMP_Text chat;

    public void yeS()
    {
        NextTextt.SetActive(false);
        yeas.SetActive(false);
        choess.SetActive(true);

        chat.text = "what shall we ask?";


    }
}

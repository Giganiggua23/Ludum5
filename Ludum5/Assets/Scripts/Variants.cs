using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variants : MonoBehaviour
{
    public TMP_Text chat;
    public GameObject NextTextt;

    public GameObject choess;

    string name = "Detectiv";
    string nS = "Sectant";
    string nG = "Ghost";
    public TMP_Text nameP;

    

    bool AGE = false;
    bool KILLER = false;    
     
    bool HAVEUFAMALY = false;

    bool AGE1 = false;
    bool KILLER1 = false;
   
    bool HAVEUFAMALY1 = false;

    public int j = 0;


    public void Age()
    {

        nameP.text = name;
        nameP.color = Color.green;

        chat.text = "how old are you?";
        NextTextt.SetActive(true);
        choess.SetActive(false);

        
        

        if (j == 1)
        {
            nameP.text = nG;
            nameP.color = Color.black;
            int i = Random.Range(1, 3);

            if (i == 1 && AGE == true)
            {
                chat.text = ". . .";
            }
            if (i == 2 && AGE1 == true)
            {
                chat.text = ". . .";
            }

            if (AGE != true && i == 1)
            {
                AGE = true;
                chat.text = "28";
            }
            if (AGE1 != true && i == 2)
            {
                AGE1 = true;
                chat.text = "41";
            }
        }
        
    }

    public void KIller()
    {
            chat.text = ". . . , you might ask \"where was he\" there is no need to mention death. You don't know how to talk to victims.";
        
    }

    public void HAVeufm()
    {
        int i = Random.Range(1, 3);

        if (i == 1 && HAVEUFAMALY == true)
        {
            chat.text = ". . .";
        }
        if (i == 2 && HAVEUFAMALY1 == true)
        {
            chat.text = ". . .";
        }

        if (HAVEUFAMALY != true && i == 1)
        {
            HAVEUFAMALY = true;
            chat.text = "children";
        }
        if (HAVEUFAMALY1 != true && i == 2)
        {
            HAVEUFAMALY1 = true;
            chat.text = "only cats";
        }
       
    }

    public void wud()
    {
        int i = Random.Range(1, 3);

        if (i == 1 && KILLER == true)
        {
            chat.text = ". . .";
        }
        if (i == 2 && KILLER1 == true)
        {
            chat.text = ". . .";
        }

        if (KILLER != true && i == 1)
        {
            KILLER = true;
            chat.text = "forest";
        }
        if (KILLER1 != true && i == 2)
        {
            KILLER1 = true;
            chat.text = "house";

        }
    }

    public void NextN()
    {
        NextTextt.SetActive(false);
        choess.SetActive(true);
        j = 1;
    }
}

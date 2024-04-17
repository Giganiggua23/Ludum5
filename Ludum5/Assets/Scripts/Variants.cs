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

    public GameObject n;
    public GameObject nn;
    public GameObject child;
    public GameObject cat;
    public GameObject nforest;
    public GameObject nhouse;


    bool AGE = false;
    bool KILLER = false;    
     
    bool HAVEUFAMALY = false;

    bool AGE1 = false;
    bool KILLER1 = false;
   
    bool HAVEUFAMALY1 = false;

    


    public void Age()
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
                n.SetActive(true);
            }
            if (AGE1 != true && i == 2)
            {
                AGE1 = true;
                chat.text = "41";
                nn.SetActive(true);
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
            child.SetActive(true);
        }
        if (HAVEUFAMALY1 != true && i == 2)
        {
            HAVEUFAMALY1 = true;
            chat.text = "only cats";
            cat.SetActive(true);
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
            nforest.SetActive(true);
        }
        if (KILLER1 != true && i == 2)
        {
            KILLER1 = true;
            chat.text = "house";
            nhouse.SetActive(true);

        }
    }

    
}

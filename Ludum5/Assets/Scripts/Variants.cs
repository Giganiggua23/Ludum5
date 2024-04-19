using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variants : MonoBehaviour
{
    public TMP_Text chat;

    public TMP_Text Tage;
    public TMP_Text Tplace;
    public TMP_Text Tfamaly;

    
    bool iage = false;
    bool iplace = false;
    bool ifamaly = false;

    bool iage2 = false;
    bool iplace2 = false;
    bool ifamaly2 = false;

    void Update()
    {
        
    }

    public void Age()
    {
        int i = Random.Range(1, 3);
        if (i == 1 && iage == true)
        {
            chat.text = ". . .";
        }
        if (i == 2 && iage2 == true)
        {
            chat.text = ". . .";
        }

        if (i == 1 && iage == false)
        {
            iage = true;
            chat.text = "28";
            Tage.text += " 28";
        }
        if (i == 2 && iage2 == false)
        {
            iage2 = true;
            chat.text = "41";
            Tage.text += " 41";
        }
        
    }

    public void Place()
    {
        int j = Random.Range(1, 3);
        if (j == 1 && iplace == true)
        {
            chat.text = ". . .";
        }
        if (j == 2 && iplace2 == true)
        {
            chat.text = ". . .";
        }
        
        if (j == 1 && iplace == false)
        {
            iplace = true;
            chat.text = "forest";
            Tplace.text += " forest";
        }
        if (j == 2 && iplace2 == false)
        {
            iplace2 = true;
            chat.text = "house";
            Tplace.text += " house";
        }
        
    }
    public void Famaly()
    {
        int l = Random.Range(1, 3);
        if (l == 1 && ifamaly == true)
        {
            chat.text = ". . .";
        }
        if (l == 2 && ifamaly2 == true)
        {
            chat.text = ". . .";
        }
        
        if (l == 1 && ifamaly == false)
        {
            ifamaly = true;
            chat.text = "children";
            Tfamaly.text += " children";
        }
        if(l == 2 && ifamaly2 == false)
        {
            ifamaly2 = true;
            chat.text = "only cats";
            Tfamaly.text += " only cats";
        }
        
    }
}

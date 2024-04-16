using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class chatWindow : MonoBehaviour
{
    public TMP_Text chat;
    public TMP_Text nameP;
    public Color TextColor;
    

    public GameObject NextTextt;
    public GameObject ready;

    string name = "Detectiv";
    string nS = "Sectant";
    string nG = "Ghost";

    int i;

    void Start()
    {
        nameP.text = nS;
        nameP.color = Color.red;
        chat.text = "- Welcome, we understand that this is probably your first experience interacting with the board, so listen carefully to the instructions.\r\nYou are required to:\r\nask questions and write down answers.";
        //- ƒобро пожаловать, мы понимаем, что, веро€тно, это ваш первый опыт взаимодействи€ с доской, так что слушайте внимательнее инструкции. 
        //ќт вас требуетс€:
        //задавать вопросы и записывать на них ответы.
    }

   
    void Update()
    {
        if (i == 1)
        {
            nameP.text = nS;
            nameP.color = Color.red;
            chat.text = "The Spirit will not repeat twice.\r\nIf the spirit's speech is poorly intelligible, I will suggest their past answers.\r\nPerhaps this will help you in choosing a question.\r\nWe cannot completely control contact, so from time to time another spirit may come to you. There is no way we can help with this.";
            //ƒух не будет повтор€ть дважды. 
            //≈сли речь духа будет слабо разборчива € подскажу их прошлые ответы.
            //¬озможно, это поможет вам в выборе вопроса.  
            //ћы не в силах полностью контролировать контакт, так что периодически к вам может прибиватьс€ другой дух.— этим помочь никак не можем.
        }
        if (i == 2)
        {
            nameP.text = nS;
            nameP.color = Color.red;
            chat.text = "Start connecting with spirit?";
            //Ќачать соединение с духом? 

            NextTextt.SetActive(false);
            ready.SetActive(true);
        }
        
    }

    public void NextText()
    {
        i++;
    }
}

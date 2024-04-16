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
        //- ����� ����������, �� ��������, ���, ��������, ��� ��� ������ ���� �������������� � ������, ��� ��� �������� ������������ ����������. 
        //�� ��� ���������:
        //�������� ������� � ���������� �� ��� ������.
    }

   
    void Update()
    {
        if (i == 1)
        {
            nameP.text = nS;
            nameP.color = Color.red;
            chat.text = "The Spirit will not repeat twice.\r\nIf the spirit's speech is poorly intelligible, I will suggest their past answers.\r\nPerhaps this will help you in choosing a question.\r\nWe cannot completely control contact, so from time to time another spirit may come to you. There is no way we can help with this.";
            //��� �� ����� ��������� ������. 
            //���� ���� ���� ����� ����� ���������� � �������� �� ������� ������.
            //��������, ��� ������� ��� � ������ �������.  
            //�� �� � ����� ��������� �������������� �������, ��� ��� ������������ � ��� ����� ����������� ������ ���.� ���� ������ ����� �� �����.
        }
        if (i == 2)
        {
            nameP.text = nS;
            nameP.color = Color.red;
            chat.text = "Start connecting with spirit?";
            //������ ���������� � �����? 

            NextTextt.SetActive(false);
            ready.SetActive(true);
        }
        
    }

    public void NextText()
    {
        i++;
    }
}

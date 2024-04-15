using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Notesedit : ReSum
{
    public TMP_Text Name_;
    public TMP_Text SurName_;
    
    void FixedUpdate()
    {
       
        Name_.text = "Name :"  + Name;
        SurName_.text = "Surname :" + Surname;

    }


}

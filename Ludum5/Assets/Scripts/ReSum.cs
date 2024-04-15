using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReSum : MonoBehaviour
{
    public string Name;
    public string Surname;
    public string gun;
    public string Story1;
    public string Story2;
    public string Story3;


    

    void Start()
    {
        int i = Random.Range(1, 6);


        switch (i)
        {
            case 1:
            Name = " Andry";
            break;

            case 2:
            Name = " Georgy";
            break;

            case 3:
            Name = " David";
            break;

            case 4:
            Name = " Lui";
            break;

            case 5:
            Name = " Bob";
            break;
        }

        int ii = Random.Range(1, 6);


        switch (ii)
        {
            case 1:
                Surname = " Adamson";
                break;

            case 2:
                Surname = " Blare";
                break;

            case 3:
                Surname = " Parson";
                break;

            case 4:
                Surname = " Ford";
                break;

            case 5:
                Surname = " Taylor";
                break;
        }


        int j = Random.Range(1, 4);


        switch (j)
        {
            case 1:
                gun = " knife";
                break;

            case 2:
                gun = " pistol";
                break;

            case 3:
                gun = " idk";
                break;
            case 4:
                gun = " hand";
                break;

            
        }

        int jj = Random.Range(1, 4);


        switch (jj)
        {
            case 1:
                Story1 = " Street";
                break;

            case 2:
                Story1 = " Forest";
                break;

            case 3:
                Story1 = " Road";
                break;
            case 4:
                Story1 = " beach";
                break;


        }

        int o = Random.Range(1, 4);


        switch (o)
        {
            case 1:
                Story2 = " morning";
                break;

            case 2:
                Story2 = " afternoon";
                break;

            case 3:
                Story2 = " evening";
                break;
            case 4:
                Story2 = " mindnight";
                break;


        }

        int oo = Random.Range(1, 4);


        switch (oo)
        {
            case 1:
                Story3 = " tall";
                break;

            case 2:
                Story3 = " short";
                break;

            case 3:
                Story3 = " fat";
                break;
            case 4:
                Story3 = " normal";
                break;


        }

    }

    
     
}

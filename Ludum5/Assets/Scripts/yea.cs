using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yea : MonoBehaviour
{
    public GameObject NextTextt;
    public GameObject yeas;
    public GameObject choess;

    public void yeS()
    {
        NextTextt.SetActive(false);
        yeas.SetActive(false);
        choess.SetActive(true);
    }
}

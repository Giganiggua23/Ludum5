using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastscene : MonoBehaviour
{
    public GameObject secondD;

    public GameObject one;
    public GameObject two;

    public void Varened()
    {
        secondD.SetActive(false);
    }

    public void ClOp()
    {
        one.SetActive(false);
        two.SetActive(true);
    }
}

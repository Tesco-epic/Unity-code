using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public GameObject scaled;
    public void OnButtonPress()
    {
        scaled.gameObject.transform.localScale += new Vector3(0, 1, 0);
    }

    public void OnButtonPress2()
    {
        scaled.gameObject.transform.localScale += new Vector3(0, -1, 0);
    }
}
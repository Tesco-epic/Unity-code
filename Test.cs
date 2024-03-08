using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
int n;
public GameObject objectToSpawn;
public void OnButtonPress()
    {
        n++;
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }


}
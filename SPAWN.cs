using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWN : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

}

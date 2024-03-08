using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMass : MonoBehaviour
{
    public GameObject Truck;
    private Rigidbody body;
    public Vector3 cntr;
    public float yaxis;


    // Start is called before the first frame update
    void Start()
    {
        body = Truck.GetComponent<Rigidbody>();
        cntr = Truck.GetComponent<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        yaxis = cntr.y;
        body.centerOfMass = new Vector3(0,yaxis,0); 
    }
}

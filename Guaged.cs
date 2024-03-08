using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guaged : MonoBehaviour
{

    public GameObject Dial;
    private float rot; //Rotation to be added
    private float crot; //Current rotation on Z axis
    public float xAngle, yAngle, zAngle;
    private float fix;
    public bool type;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (type) //Speedometer MPH
        {
            rot = CarController.Speed / 130;
            crot = Dial.transform.localRotation.z;
            yAngle = Dial.transform.localRotation.y;
            xAngle = Dial.transform.localRotation.x;
            zAngle = crot + rot;
            if (zAngle > 1)
            {
                zAngle = crot;
            }
 
                



            Dial.transform.Rotate(0, 0, -zAngle);
        }

        if (type == false) //Speedometer RPM
        {
            rot = CarController.Revs / 5000;  //Max Revs is 5000
            crot = Dial.transform.localRotation.z;
            yAngle = Dial.transform.localRotation.y;
            xAngle = Dial.transform.localRotation.x;
            zAngle = crot + rot;
            if (zAngle > 1)
            {
                zAngle = crot;
            }


            Dial.transform.Rotate(0, 0, -zAngle);

        }
    }
}

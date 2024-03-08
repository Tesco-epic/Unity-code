using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public GameObject Meter;
    public static Text speedt;
    public bool type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (type)
        {
            speedt = Meter.GetComponent<Text>();
            speedt.text = CarController.Speed.ToString();
        }

        if (type == false)
        {
            speedt = Meter.GetComponent<Text>();
            speedt.text = CarController.Revs.ToString();

        }
    }
}

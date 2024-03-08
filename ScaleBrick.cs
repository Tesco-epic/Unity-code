using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class ScaleBrick : MonoBehaviour
{
    public Vector3 position;
    public Vector3 size;
    public bool x;
    public bool y;
    public bool z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Xbutton()
    { 
        x = true;
        y = false;
        z = false;
    }

    public void Ybutton()
    {
        x = false;
        y = true;
        z = false;
    }

    public void Zbutton()
    {
        x = false;
        y = false;
        z = true;
    }

    void OnMouseDown()
    {
        if (x == true)
        {
            transform.localScale = new Vector3(size.x +=1, size.y, size.z);
        }

        if (y == true)
        {
            transform.localScale = new Vector3(size.x, size.y +=1, size.z);
        }

        if (z == true)
        {
            transform.localScale = new Vector3(size.x, size.y, size.z +=1);
        }
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject objectToSpawn5;
    public GameObject objectToSpawn6;
    public GameObject objectToSpawn7;
    public GameObject objectToSpawn8;
    public GameObject objectToSpawn9;
    public GameObject objectToSpawn10;
    public GameObject objectToSpawn11;
    public GameObject objectToSpawn12;
    public GameObject objectToSpawn13;
    public GameObject objectToSpawn14;
    public GameObject objectToSpawn15;
    public GameObject objectToSpawn16;
    public GameObject objectToSpawn17;
    public GameObject objectToSpawn18;
    public GameObject objectToSpawn19;
    public GameObject objectToSpawn20;
    public GameObject objectToSpawn21;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("e"))
        {
            Instantiate(objectToSpawn2, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("r"))
        {
            Instantiate(objectToSpawn3, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("t"))
        {
            Instantiate(objectToSpawn4, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("y"))
        {
            Instantiate(objectToSpawn5, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("u"))
        {
            Instantiate(objectToSpawn13, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("i"))
        {
            Instantiate(objectToSpawn6, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("o"))
        {
            Instantiate(objectToSpawn7, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("p"))
        {
            Instantiate(objectToSpawn8, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("f"))
        {
            Instantiate(objectToSpawn9, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("g"))
        {
            Instantiate(objectToSpawn10, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("h"))
        {
            Instantiate(objectToSpawn11, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("j"))
        {
            Instantiate(objectToSpawn12, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("k"))
        {
            Instantiate(objectToSpawn13, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("l"))
        {
            Instantiate(objectToSpawn14, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("z"))
        {
            Instantiate(objectToSpawn15, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("x"))
        {
            Instantiate(objectToSpawn16, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("c"))
        {
            Instantiate(objectToSpawn17, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("v"))
        {
            Instantiate(objectToSpawn18, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("b"))
        {
            Instantiate(objectToSpawn19, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("n"))
        {
            Instantiate(objectToSpawn20, transform.position, transform.rotation);
        }

        if (Input.GetButtonDown("m"))
        {
            Instantiate(objectToSpawn21, transform.position, transform.rotation);
        }
    }
}

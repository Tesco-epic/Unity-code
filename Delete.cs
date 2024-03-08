using System.Collections;
using System.Collections.Generic;
using Lightbug.GrabIt;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Destroy(collision.gameObject);
        }
    }

}

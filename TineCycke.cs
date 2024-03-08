using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TineCycke : MonoBehaviour
{
    public GameObject cycle;
    public GameObject Enemy;
    public float delay = 1;
    float timer;
    private Light gogaga;

    // Start is called before the first frame update
    void Start()
    {
        gogaga = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > delay )
        {
            cycle.transform.Rotate(+1f, 0f, 0f);
            gogaga.intensity = cycle.gameObject.transform.localRotation.eulerAngles.x / 10f;
            if ( gogaga.intensity > 20f)
            {
                gogaga.intensity = 0f;
            }

            if (gogaga.intensity > 2f && gogaga.intensity < 19f)
            {
                gogaga.intensity = 1f;
            }


            if ( gogaga.intensity == 0f)
            {
                gogaga.color = Color.black;
                RenderSettings.ambientLight = Color.black;
                RenderSettings.ambientSkyColor = Color.black;

            }

            RenderSettings.ambientIntensity = gogaga.intensity;
            timer = 0f;
        }

    }
}

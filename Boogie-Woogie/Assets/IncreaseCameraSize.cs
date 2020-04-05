using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseCameraSize : MonoBehaviour
{
    Camera maincamera;
    public float IncreaseRate;
    public float maxCameraSize;
    bool wasdf;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = Camera.main;
        wasdf = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (wasdf == true)
        {
            if (maincamera.orthographicSize <= maxCameraSize)
            {
                maincamera.orthographicSize += IncreaseRate * Time.deltaTime;
            }
        }

        

    }

    public void oiuahydfoalifhdg()
    {
        wasdf = true;
    }

}

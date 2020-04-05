using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetected : MonoBehaviour
{
    public bool playerDetected;
    // Start is called before the first frame update
    void Start()
    {
        playerDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void detectPlayer()
    {
        playerDetected = true;
    }
}

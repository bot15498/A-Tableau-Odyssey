using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpawn : MonoBehaviour
{
    private float timer;
    public float spawnrate;
    public GameObject water;
   
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if(timer >= spawnrate)
        {
            Instantiate(water, transform.position, transform.rotation);
            timer = 0;
        }
    }


}

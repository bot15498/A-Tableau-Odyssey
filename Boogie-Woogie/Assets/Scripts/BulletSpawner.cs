using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
	public GameObject bullet;
	public float fireRate = 1f;
	private float currTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if(currTime > fireRate)
		{
			Instantiate(bullet, transform.position, Quaternion.identity);
			currTime = 0f;
		}
		currTime += Time.deltaTime;
	}
}

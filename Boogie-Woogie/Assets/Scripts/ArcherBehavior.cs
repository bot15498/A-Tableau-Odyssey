using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBehavior : MonoBehaviour
{
	public GameObject arrow;
	public float fireRate = 1f;
	public float fireAngle = 45f;
	public float force = 100f;

	private GameObject player;
	private float currTime = 0f;

    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
	}

    void Update()
    {
		if(currTime > fireRate)
		{
			GameObject spawnedArrow = Instantiate(arrow, transform.position, Quaternion.Euler(0, 0, fireAngle));
			spawnedArrow.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1f, 1f));
			currTime = 0f;
		}
		currTime += Time.deltaTime;

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBehavior : MonoBehaviour
{
	public GameObject arrow;
	public float fireRate = 1f;
	public float fireAngle = 45f;
	public float force = 100f;
	public bool fire = false;

	private GameObject player;
	private float currTime = 0f;
	public PlayerDetected pd;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		pd = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerDetected>();
	}

	void Update()
	{
		if (pd.playerDetected)
		{
			fire = true;
		}
	}

	private void FixedUpdate()
	{
		if(fire)
		{
			if (currTime > fireRate)
			{
				Debug.Log(currTime);
				GameObject spawnedArrow = Instantiate(arrow, transform.position, Quaternion.Euler(0, 0, fireAngle));
				spawnedArrow.GetComponent<Rigidbody2D>().AddForce(new Vector2(-Mathf.Sin(Mathf.Deg2Rad * fireAngle), Mathf.Cos(Mathf.Deg2Rad * fireAngle)) * force);
				currTime = 0f;
			}
			currTime += Time.deltaTime;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
	public float displacementUp = 8f;
	private Vector2 startPos;

    void Start()
    {
		startPos = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnTriggerActivate()
	{
		transform.position = Vector2.MoveTowards(transform.position, startPos + new Vector2(0, displacementUp), 10 * Time.deltaTime);
	}

	public void OnTriggerDeactivate()
	{
		transform.position = Vector2.MoveTowards(transform.position, startPos, 10 * Time.deltaTime);
	}
}

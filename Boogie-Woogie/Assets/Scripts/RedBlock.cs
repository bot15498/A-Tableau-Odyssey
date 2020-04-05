using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlock : MonoBehaviour
{
	public GameObject RedBullet;

	private float last = 0f;

	void Start()
    {
        
    }

    void Update()
    {
        
    }

	private void FixedUpdate()
	{
		float curr = Input.GetAxisRaw("Fire1");
		if (curr > 0 && curr != last)
		{
			GameObject bullet = Instantiate(RedBullet, transform.position , Quaternion.identity);
			bullet.transform.SetParent(this.transform.parent.parent);
		}
		last = curr;
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{

	}
}

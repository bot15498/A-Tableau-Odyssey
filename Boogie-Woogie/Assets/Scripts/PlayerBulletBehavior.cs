using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletBehavior : MonoBehaviour
{
	public float speed = 4f;
	public int damage = 1;

	private Rigidbody2D rb2d;

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.velocity = transform.parent.right * speed;
	}

    void Update()
    {
        
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
	public int damage = 1;
	//public float knockBackForce = 500f;

	void Start()
    {
        
    }

    void Update()
    {
        
    }

	public void OnCollisionEnter2D(Collision2D collision)
	{
		Collider2D actual = collision.GetContact(0).collider;
		if (collision.gameObject.tag == "Player" && actual.gameObject.GetComponent<BlueBlock>() == null)
		{
			collision.gameObject.GetComponentInParent<PlayerStats>().TakeDamage(damage);
			Vector2 moveDirection = collision.gameObject.transform.position - transform.position;
			//collision.gameObject.GetComponentInParent<Rigidbody2D>().AddForce(Vector2.left * knockBackForce);
		}
	}
}

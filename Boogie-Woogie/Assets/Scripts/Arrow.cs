using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public int damage = 1;

	private Rigidbody2D rb2d;

	// Start is called before the first frame update
	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnCollisionEnter2D(Collision2D collision)
	{
		Collider2D actual = collision.GetContact(0).collider;
		if (collision.gameObject.tag == "Player" && actual.gameObject.GetComponent<YellowBlock>() == null)
		{
			collision.gameObject.GetComponentInParent<PlayerStats>().TakeDamage(damage);
		}
		Destroy(gameObject);
	}
}

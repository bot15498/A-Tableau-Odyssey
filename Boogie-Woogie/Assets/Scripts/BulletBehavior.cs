using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed;
	public int damage = 1;

	private Transform player;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        target = new Vector2(player.position.x, player.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
		Collider2D actual = collision.GetContact(0).collider;
		Debug.Log("Actual name " + actual.gameObject.name);
		Debug.Log("Actual name " + actual.gameObject);
		if (collision.gameObject.tag == "Player" && actual.gameObject.GetComponent<YellowBlock>() == null)
		{
			collision.gameObject.GetComponentInParent<PlayerStats>().TakeDamage(damage);
		}
		Destroy(gameObject);
    }


}

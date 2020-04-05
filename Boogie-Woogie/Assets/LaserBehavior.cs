using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    public float speed;
    public int damage = 1;
    Rigidbody2D rb;
    private Transform player;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;

    }



    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D actual = collision.GetContact(0).collider;
        if (collision.gameObject.tag == "Player" && actual.gameObject.GetComponent<YellowBlock>() == null)
        {
            collision.gameObject.GetComponentInParent<PlayerStats>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}

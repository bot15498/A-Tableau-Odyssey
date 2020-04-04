using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoBehavior : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public bool isRight;
    Collider2D cd;
    SpriteRenderer sr;
    Vector2 DetectionDirection;
    public float DetectionDistance;
    public GameObject Player;
    bool foundPlayer;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<Collider2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        DetectionDirection = -transform.right;
        foundPlayer = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, DetectionDirection, DetectionDistance);
        Debug.DrawLine(transform.position, hitInfo.point, Color.green);
        if (hitInfo.collider != null)
        {
            foundPlayer = true;
        }
        else
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.green);
        }
        if(foundPlayer == true)
        {
            anim.SetBool("Detected", true);
            var position = Vector3.MoveTowards(transform.position,new Vector3( Player.transform.position.x,transform.position.y,transform.position.z), speed * Time.deltaTime);
            rb.MovePosition(position);
        }
        if(Player.transform.position.x >= gameObject.transform.position.x)
        {
            sr.flipX = true;
            anim.SetBool("RollingRight", true);
        }
        else
        {
            sr.flipX = false;
            anim.SetBool("RollingRight", false);
        }

    }

  
}

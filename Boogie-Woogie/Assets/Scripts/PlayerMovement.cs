using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    public float distance;
    public float JumpForce;
    public Transform groundDetection;


    [SerializeField]
    private bool NearGround;
    private Rigidbody2D rb;
    private float inputHorizontal;
    private int numberofjumps;
    bool facingRight;
    SpriteRenderer sr;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        NearGround = true;
        facingRight = true;
        sr = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        //GroundedCheck;
        RaycastHit2D GroundInfo = Physics2D.Raycast(groundDetection.position, -transform.up, distance);
        Debug.DrawLine(groundDetection.position, groundDetection.position + -transform.up * distance, Color.green);
        if (GroundInfo.collider != null && GroundInfo.transform.tag == "Ground")
        {
            //Debug.Log("nearground");
            
            //DO CIRCLE CAST
        }


        //Gravity Movement

        inputHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * maxSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && NearGround == true)
        {
            rb.velocity = Vector2.up * JumpForce;
            NearGround = false;
        }



        //current mouse position
        var mousePos = Input.mousePosition;

        mousePos.z = gameObject.transform.position.z;
        var delta = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;
        var alpha = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        alpha.z = transform.position.z;

        //CharacterFlipping
        if (delta.x >= 0 && !facingRight)
        { // mouse is on right side of player

         
            sr.flipX = false;
            facingRight = true;

        }
        else if (delta.x < 0 && facingRight)
        { // mouse is on left side
            

            sr.flipX = true;
            facingRight = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NearGround = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunIsPissed : MonoBehaviour
{
    private bool isPissed;
    GameObject player;
    public float fireRate;
    public GameObject bullet;
    private float timer;
    public GameObject firepoint;
    public CameraFollow follow;
    public GameObject sunspot;
    private Vector2 target;
    Animator anim;
    public float speed;
    public GameObject playerlight;
    public GameObject sunlight;
    // Start is called before the first frame update
    void Start()
    {
        isPissed = false;
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        target = new Vector2(sunspot.transform.position.x, sunspot.transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        

        if (isPissed == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
            timer += 1 * Time.deltaTime;

            if(timer >= fireRate)
            {
                Instantiate(bullet, firepoint.transform.position, Quaternion.identity);
                timer = 0;
            }
        }
    }

    public void pissed()
    {
        follow.enabled = false;
        isPissed = true;
    }

    public void sunDie()
    {
        anim.SetBool("Death", true);
    }

    public void destroySun()
    {
        playerlight.SetActive(true);
        sunlight.SetActive(false);
        Destroy(gameObject);
    }

    public void suntransition()
    {
        anim.SetBool("startpissed", true);
    }
}

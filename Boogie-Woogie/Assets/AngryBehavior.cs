using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBehavior : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public GameObject Player;
    bool foundPlayer;
    PlayerDetected pd;
    bool playerdetection;
    public GameObject pissed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        pd = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerDetected>();
        foundPlayer = false;
        pissed.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        playerdetection = pd.playerDetected;


        if (playerdetection == true)
        {
            foundPlayer = true;
        }

        
        if (foundPlayer == true)
        {
            pissed.SetActive(true);
            var position = Vector3.MoveTowards(transform.position, new Vector3(Player.transform.position.x, transform.position.y, transform.position.z), speed * Time.deltaTime);
            rb.MovePosition(position);
        }


    }
}

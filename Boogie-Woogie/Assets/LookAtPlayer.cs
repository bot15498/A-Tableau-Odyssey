using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Transform player;
    bool fightstarted;
    public float firerate;
    private float timer;
    public GameObject laser;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        fightstarted = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = player.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotateSpeed);

        if (fightstarted == true)
        {
            timer += 1 * Time.deltaTime;
            if(timer >= firerate)
            {
                Debug.Log("adfasdf");
                Instantiate(laser, transform.position, transform.rotation);
                timer = 0;
            }
        }
    }

    public void startFight()
    {
        fightstarted = true;
    }
}

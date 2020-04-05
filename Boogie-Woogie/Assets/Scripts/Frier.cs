using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frier : MonoBehaviour
{
    public GameObject fries;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("fry");
            Instantiate(fries, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}

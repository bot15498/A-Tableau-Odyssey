using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxhealth;
    private float currenthealth;
    public GameObject deathanimation;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        sr = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (currenthealth <= 0)
        {
            die();
        }
    }

    public void takeDamage()
    {
        currenthealth -= 1;
        StartCoroutine(colorChange());
    }
    void die()
    {
        Instantiate(deathanimation, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator colorChange()
    {
        sr.color = new Color(255f, 0f, 0f, 1f);
        yield return new WaitForSeconds(1);

        sr.color = new Color(1f, 1f, 1f, 1f);
    }
}

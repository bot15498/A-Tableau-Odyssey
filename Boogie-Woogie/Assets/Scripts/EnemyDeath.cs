using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float deathtimer = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DIE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DIE()
    {
        yield return new WaitForSeconds(deathtimer);

        Destroy(gameObject);
    }
}

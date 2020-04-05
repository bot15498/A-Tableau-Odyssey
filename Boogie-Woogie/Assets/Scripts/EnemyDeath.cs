using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
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
        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}

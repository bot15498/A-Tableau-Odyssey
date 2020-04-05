using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
	public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TakeDamage(int amount)
	{
		health -= amount;
		// update UI
		if(health <= 0)
		{
			Debug.Log("You died");
		}
	}
}

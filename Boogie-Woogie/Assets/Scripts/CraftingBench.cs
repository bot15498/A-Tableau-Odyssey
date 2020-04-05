using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingBench : MonoBehaviour
{
	public GameObject WeaponBuilderCanvas;
	private bool canBuild = false;

    void Start()
    {
        
    }

    void Update()
    {
		if(canBuild && Input.GetKeyDown(KeyCode.F))
		{
			WeaponBuilderCanvas.SetActive(true);
			canBuild = false;
			Time.timeScale = 0f;
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
		{
			// show prompt to press f
			canBuild = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			// hide prompt to press f
			canBuild = false;
		}
	}
}

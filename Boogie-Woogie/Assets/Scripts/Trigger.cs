using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
	public bool holdTrigger = false;
	public UnityEvent onTrigger;
	public UnityEvent offTrigger;
	public UnityEvent whileTrigger;

	void Start()
    {
        
    }

    void Update()
    {
        
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "TriggerDummy")
		{
			onTrigger.Invoke();
			Debug.Log("enter");
		}
	}

	public void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "TriggerDummy")
		{
			whileTrigger.Invoke();
		}
	}

	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "TriggerDummy")
		{
			offTrigger.Invoke();
			Debug.Log("enter");
		}
	}

}

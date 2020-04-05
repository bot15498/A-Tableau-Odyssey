using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUnlockTrigger : MonoBehaviour
{
	public bool unlockYellow = false;
	public bool unlockRed = false;

	private PersistantData pd;

    // Start is called before the first frame update
    void Start()
    {
		pd = FindObjectOfType<PersistantData>();
	}

    // Update is called once per frame
    void Update()
    {
        if(pd == null)
		{
			pd = FindObjectOfType<PersistantData>();
		}
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if(unlockYellow)
		{
			pd.ActivateYellow();
		}
		if (unlockRed)
		{
			pd.ActivateRed();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSector : MonoBehaviour
{
	public GameObject YellowSector;
	private PersistantData data;

    void Start()
    {
		if (data == null)
		{
			data = FindObjectOfType<PersistantData>();
		}
		YellowSector.SetActive(data.unlockYellow);
	}

	void Update()
    {
        if(data == null)
		{
			data = FindObjectOfType<PersistantData>();
			YellowSector.SetActive(data.unlockYellow);
		}
    }
}

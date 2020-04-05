using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantData : MonoBehaviour
{
	public bool unlockYellow = false;
	public bool unlockRed = false;
	public WeaponBuilder builder;

	private static PersistantData currInstance;

	void Start()
	{
		WeaponBuilder[] temp = Resources.FindObjectsOfTypeAll<WeaponBuilder>();
		if (temp.Length > 0)
		{
			builder = temp[0];
			builder.YellowButtons.SetActive(unlockYellow);
			builder.RedButtons.SetActive(unlockRed);
		}
	}

	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		if (currInstance == null)
		{
			currInstance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		if (builder == null)
		{
			WeaponBuilder[] temp = Resources.FindObjectsOfTypeAll<WeaponBuilder>();
			if (temp.Length > 0)
			{
				builder = temp[0];
				builder.YellowButtons.SetActive(unlockYellow);
				builder.RedButtons.SetActive(unlockRed);
			}
		}
	}

	public void ActivateYellow()
	{
		unlockYellow = true;
		builder.YellowButtons.SetActive(true);
	}

	public void ActivateRed()
	{
		unlockRed = true;
		builder.RedButtons.SetActive(true);
	}
}

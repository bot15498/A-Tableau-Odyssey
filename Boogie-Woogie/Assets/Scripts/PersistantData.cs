﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantData : MonoBehaviour
{
	public bool unlockYellow = false;
	public bool unlockRed = false;
	public WeaponBuilder builder;
	void Start()
	{
		DontDestroyOnLoad(this.gameObject);
		builder = FindObjectOfType<WeaponBuilder>();
		if (builder != null)
		{
			builder.YellowButtons.SetActive(unlockYellow);
			builder.RedButtons.SetActive(unlockRed);
		}
	}

	void Update()
	{
		if (builder == null)
		{
			builder = FindObjectOfType<WeaponBuilder>();
			if (builder != null)
			{
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

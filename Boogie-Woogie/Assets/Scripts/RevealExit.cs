using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealExit : MonoBehaviour
{
	public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
		exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

	public void ActivateExit()
	{
		exit.SetActive(true);
	}
}

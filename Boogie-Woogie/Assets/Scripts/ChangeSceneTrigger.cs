using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTrigger : MonoBehaviour
{
	public string nextScene;

	private bool canTeleport = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canTeleport && Input.GetKeyDown(KeyCode.F))
		{
			SceneManager.LoadScene(nextScene);
		}
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
		canTeleport = true;
	}

	public void OnTriggerExit2D(Collider2D collision)
	{
		canTeleport = false;
	}
}

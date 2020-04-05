using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
	public int health = 3;
	public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
		healthText.text = "Health: " + health;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TakeDamage(int amount)
	{
		health -= amount;
		// update UI
		healthText.text = "Health: " + health;
		if (health <= 0)
		{
			Debug.Log("You died");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void GetHealth(int amount)
	{
		health += amount;
		// update UI
		healthText.text = "Health: " + health;
	}
}

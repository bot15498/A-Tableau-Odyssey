using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpColors : MonoBehaviour
{
	public float duration = 1f;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(change());
    }

    // Update is called once per frame
    void Update()
    {

	}

	public IEnumerator change()
	{
		while(true)
		{
			float currTime = 0f;
			while (currTime < duration)
			{
				currTime += Time.deltaTime;
				float h = Mathf.Lerp(0, 1, currTime / duration);
				GetComponent<Camera>().backgroundColor = Color.HSVToRGB(h, 1, 0.5f);
				yield return null;
			}
		}
	}
}

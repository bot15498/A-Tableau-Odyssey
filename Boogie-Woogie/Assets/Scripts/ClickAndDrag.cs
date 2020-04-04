using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAndDrag : EventTrigger
{
	private bool isSelected = false;
	private Vector2 diff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isSelected)
		{
			transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		}
    }

	public override void OnPointerDown(PointerEventData eventData)
	{
		//diff = new Vector2(transform.position.x, transform.position.y) + eventData.pressPosition;
		//Debug.Log(diff);
		isSelected = true;
		transform.SetAsLastSibling();
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		isSelected = false;
	}
}

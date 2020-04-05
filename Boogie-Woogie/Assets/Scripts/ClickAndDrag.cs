using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAndDrag : EventTrigger
{
	public float widthBounds = 745 / 2.0f;
	public float heightBounds = 685 / 2.0f;
	private bool isSelected = false;
	private Vector2 diff;
	private RectTransform rect;
	private float objectWidth;
	private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
		rect = GetComponent<RectTransform>();
		objectWidth = rect.sizeDelta.x / 2f;
		objectHeight = rect.sizeDelta.y / 2f;

	}

    // Update is called once per frame
    void Update()
    {
		if (rect == null)
		{
			rect = GetComponent<RectTransform>();
			objectWidth = rect.sizeDelta.x / 2f;
			objectHeight = rect.sizeDelta.y / 2f;
		}

        if(isSelected)
		{
			if (transform.localPosition.x + objectWidth > widthBounds
				|| transform.localPosition.x - objectWidth < -widthBounds
				|| transform.localPosition.y + objectHeight > heightBounds
				|| transform.localPosition.y - objectHeight < -heightBounds)
			{
				isSelected = false;
				FixPosition();
			}
			else
			{
				transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			}
		}
    }

	public override void OnPointerDown(PointerEventData eventData)
	{
		FixPosition();
		isSelected = true;
		transform.SetAsLastSibling();
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		FixPosition();
		isSelected = false;
	}

	private void FixPosition()
	{
		float newX = transform.localPosition.x;
		float newY = transform.localPosition.y;
		if (transform.localPosition.x + objectWidth > widthBounds)
		{
			newX = widthBounds - objectWidth - 1;
		}
		if (transform.localPosition.x - objectWidth < -widthBounds)
		{
			newX = -widthBounds + objectWidth + 1;
		}
		if (transform.localPosition.y + objectHeight > heightBounds)
		{
			newY = heightBounds - objectHeight - 1;
		}
		if (transform.localPosition.y - objectHeight < -heightBounds)
		{
			newY = -heightBounds + objectHeight + 1;
		}
		transform.localPosition = new Vector3(newX, newY);
	}
}

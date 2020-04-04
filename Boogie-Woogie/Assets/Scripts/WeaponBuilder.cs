using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum WeaponPieceType
{
	WhiteSquare = 0,
	BlueSquare = 1,
	YellowSquare = 2,
	RedSquare = 3,
	WhiteRect = 4,
	BlueRect = 5,
	YellowRect = 6,
	RedRect = 7,
	WhiteRectHort = 8,
	BlueRectHort = 9,
	YellowRectHort = 10,
	RedRectHort = 11
}

public class WeaponBuilder : MonoBehaviour
{
	public float weaponScaling = 0.03f;
	public GameObject craftingTable;
	public GameObject hilt;
	public GameObject weapon;
	public Sprite yellowSprite;
	public Sprite blueSprite;
	public Sprite whiteSprite;
	public Sprite redSprite;
	public Sprite hiltSprite;
	[SerializeField]
	private List<GameObject> pieces = new List<GameObject>();


	void Start()
	{

	}

	void Update()
	{

	}

	public void Awake()
	{
		// load current ?
	}

	public void OnWeaponPieceClick(int type)
	{
		// create game obeject
		GameObject img = new GameObject("weaponObj");
		RectTransform rectTransform = img.AddComponent<RectTransform>();
		img.AddComponent<CanvasRenderer>();
		Image currImage = img.AddComponent<Image>();
		img.transform.SetParent(craftingTable.transform);
		img.transform.localPosition = new Vector3(0, 0, 0);
		img.AddComponent<ClickAndDrag>();
		currImage.type = Image.Type.Tiled;
		pieces.Add(img);

		switch ((WeaponPieceType)type)
		{
			case WeaponPieceType.WhiteSquare:
				//img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.WhiteRect:
				//currImage.color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.WhiteRectHort:
				//currImage.color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 400);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.BlueSquare:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = blueSprite;
				break;
			case WeaponPieceType.BlueRect:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = blueSprite;
				break;
			case WeaponPieceType.BlueRectHort:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 400);
				currImage.sprite = blueSprite;
				break;
			case WeaponPieceType.YellowSquare:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = yellowSprite;
				break;
			case WeaponPieceType.YellowRect:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = yellowSprite;
				break;
			case WeaponPieceType.YellowRectHort:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 400);
				currImage.sprite = yellowSprite;
				break;
			case WeaponPieceType.RedSquare:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = redSprite;
				break;
			case WeaponPieceType.RedRect:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 400);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
				currImage.sprite = redSprite;
				break;
			case WeaponPieceType.RedRectHort:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 400);
				currImage.sprite = redSprite;
				break;
			default:
				currImage.color = new Color32(217, 28, 217, 255);
				break;
		}
	}

	public void SaveWeapon()
	{
		//clear weapon in world
		for (int i = 0; i < weapon.transform.childCount; i++)
		{
			Destroy(weapon.transform.GetChild(i).gameObject);
		}
		weapon.SetActive(false);

		GameObject temp = new GameObject("tempWeapon");

		// save to weapon game object
		Vector3 hiltPosInWorld = hilt.transform.position;
		GameObject hiltReal = new GameObject("hilt");
		SpriteRenderer sr = hiltReal.AddComponent<SpriteRenderer>();
		sr.sprite = hiltSprite;
		sr.drawMode = SpriteDrawMode.Sliced;
		sr.size = hilt.GetComponent<RectTransform>().sizeDelta;
		hiltReal.AddComponent<BoxCollider2D>();
		hiltReal.layer = LayerMask.NameToLayer("Player");
		hiltReal.tag = "Player";
		//Vector3 parentScale = hiltReal.transform.parent.sc
		//Vector3 scale = new Vector3(hiltReal.transform.localScale.x, hiltReal.transform.localScale.y);
		//Debug.Log("Hilt real scale: " + scale);
		//Vector3 properScale = new Vector3(1 / scale.x, 1 / scale.y, 0);
		//hiltReal.transform.localScale = properScale;
		//hiltReal.transform.position = new Vector3(hiltReal.transform.position.x * properScale.x,
		//											hiltReal.transform.position.y * properScale.y,
		//											hiltReal.transform.position.z);
		hiltReal.transform.SetParent(temp.transform);



		for (int i = 0; i < craftingTable.transform.childCount; i++)
		{
			GameObject uiChild = craftingTable.transform.GetChild(i).gameObject;
			if (!uiChild.Equals(hilt))
			{
				Vector3 diff = uiChild.transform.position - hiltPosInWorld;
				GameObject weaponComponentReal = new GameObject("weaponBlock");
				SpriteRenderer wsr = weaponComponentReal.AddComponent<SpriteRenderer>();
				wsr.sprite = uiChild.GetComponent<Image>().sprite;
				wsr.drawMode = SpriteDrawMode.Sliced;
				wsr.size = uiChild.GetComponent<RectTransform>().sizeDelta;
				Debug.Log(diff);
				weaponComponentReal.transform.localPosition = diff;
				weaponComponentReal.AddComponent<BoxCollider2D>();
				weaponComponentReal.layer = LayerMask.NameToLayer("Player");
				weaponComponentReal.tag = "Player";
				//Vector3 weaponScale = weaponComponentReal.transform.lossyScale;
				//Vector3 properWeaponScale = new Vector3(1 / weaponScale.x, 1 / weaponScale.y, 0);
				//weaponComponentReal.transform.localScale = properWeaponScale;
				//weaponComponentReal.transform.position = new Vector3(weaponComponentReal.transform.position.x * properWeaponScale.x,
				//													weaponComponentReal.transform.position.y * properWeaponScale.y,
				//													weaponComponentReal.transform.position.z);
				weaponComponentReal.transform.SetParent(temp.transform);
			}
		}

		//finally scale down weapon to fit.
		temp.transform.SetParent(weapon.transform);
		temp.transform.rotation = Quaternion.Euler(0, 0, -90);
		weapon.transform.localScale = new Vector3(weaponScaling, weaponScaling);
		weapon.SetActive(true);

		this.gameObject.SetActive(false);
	}

	public void ClearWeapon()
	{
		foreach (GameObject o in pieces)
		{
			Destroy(o);
		}
	}
}

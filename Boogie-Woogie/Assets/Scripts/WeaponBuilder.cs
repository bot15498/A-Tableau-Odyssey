using System.Collections;
using System.Collections.Generic;
using TMPro;
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
	public TextMeshProUGUI errorTextBox;
	public Sprite yellowSprite;
	public Sprite blueSprite;
	public Sprite whiteSprite;
	public Sprite redSprite;
	public Sprite hiltSprite;
	public GameObject YellowButtons;
	public GameObject RedButtons;
	public List<float> squareDim = new List<float> { 100f, 100f};
	public List<float> rectDim = new List<float> { 50f, 200f };

	[SerializeField]
	private List<GameObject> pieces = new List<GameObject>();
	private float offsetSpawnFromPlayerCenter = 100f;


	void Start()
	{
		errorTextBox.gameObject.SetActive(false);
	}

	void Update()
	{

	}

	public void Awake()
	{
		// load current ?
		errorTextBox.gameObject.SetActive(false);
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
		img.transform.localScale = new Vector3(1f, 1f, 1f);
		img.AddComponent<ClickAndDrag>();
		currImage.type = Image.Type.Tiled;
		pieces.Add(img);

		switch ((WeaponPieceType)type)
		{
			case WeaponPieceType.WhiteSquare:
				//img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, squareDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, squareDim[1]);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.WhiteRect:
				//currImage.color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[1]);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.WhiteRectHort:
				//currImage.color = new Color32(255, 255, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[1]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[0]);
				currImage.sprite = whiteSprite;
				break;
			case WeaponPieceType.BlueSquare:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, squareDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, squareDim[1]);
				currImage.sprite = blueSprite;
				img.AddComponent<BlueBlock>();
				break;
			case WeaponPieceType.BlueRect:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[1]);
				currImage.sprite = blueSprite;
				img.AddComponent<BlueBlock>();
				break;
			case WeaponPieceType.BlueRectHort:
				//currImage.color = new Color32(0, 63, 255, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[1]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[0]);
				currImage.sprite = blueSprite;
				img.AddComponent<BlueBlock>();
				break;
			case WeaponPieceType.YellowSquare:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, squareDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, squareDim[1]);
				currImage.sprite = yellowSprite;
				img.AddComponent<YellowBlock>();
				break;
			case WeaponPieceType.YellowRect:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[1]);
				currImage.sprite = yellowSprite;
				img.AddComponent<YellowBlock>();
				break;
			case WeaponPieceType.YellowRectHort:
				//currImage.color = new Color32(229, 241, 24, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[1]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[0]);
				currImage.sprite = yellowSprite;
				img.AddComponent<YellowBlock>();
				break;
			case WeaponPieceType.RedSquare:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, squareDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, squareDim[1]);
				currImage.sprite = redSprite;
				img.AddComponent<RedBlock>();
				break;
			case WeaponPieceType.RedRect:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[0]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[1]);
				currImage.sprite = redSprite;
				img.AddComponent<RedBlock>();
				break;
			case WeaponPieceType.RedRectHort:
				//currImage.color = new Color32(221, 16, 16, 255);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, rectDim[1]);
				rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectDim[0]);
				currImage.sprite = redSprite;
				img.AddComponent<RedBlock>();
				break;
			default:
				currImage.color = new Color32(217, 28, 217, 255);
				break;
		}
	}

	public void SaveWeapon()
	{
		if(!CheckValidWeapon())
		{
			StopAllCoroutines();
			StartCoroutine(ShowErrorText("Error: Not all pieces are connected!", 1f));
			return;
		}

		//clear weapon in world
		for (int i = 0; i < weapon.transform.childCount; i++)
		{
			Destroy(weapon.transform.GetChild(i).gameObject);
		}
		weapon.SetActive(false);

		GameObject temp = new GameObject("tempWeapon");

		// save to weapon game object
		Vector3 hiltPosInWorld = hilt.transform.localPosition;
		GameObject hiltReal = new GameObject("hilt");
		SpriteRenderer sr = hiltReal.AddComponent<SpriteRenderer>();
		sr.sprite = hiltSprite;
		sr.drawMode = SpriteDrawMode.Sliced;
		sr.size = hilt.GetComponent<RectTransform>().sizeDelta;
		hiltReal.transform.localPosition = hiltReal.transform.localPosition + new Vector3(0f, offsetSpawnFromPlayerCenter, 0f);
		BoxCollider2D collider = hiltReal.AddComponent<BoxCollider2D>();
		collider.size = sr.size;
		hiltReal.layer = LayerMask.NameToLayer("Player");
		hiltReal.tag = "Player";
		hiltReal.transform.SetParent(temp.transform);

		for (int i = 0; i < craftingTable.transform.childCount; i++)
		{
			GameObject uiChild = craftingTable.transform.GetChild(i).gameObject;
			if (!uiChild.Equals(hilt))
			{
				Vector3 diff = uiChild.transform.localPosition - hiltPosInWorld;
				GameObject weaponComponentReal = new GameObject("weaponBlock");
				SpriteRenderer wsr = weaponComponentReal.AddComponent<SpriteRenderer>();
				wsr.sprite = uiChild.GetComponent<Image>().sprite;
				wsr.drawMode = SpriteDrawMode.Sliced;
				wsr.size = uiChild.GetComponent<RectTransform>().sizeDelta;
				Debug.Log(diff);
				weaponComponentReal.transform.localPosition = diff + new Vector3(0f, offsetSpawnFromPlayerCenter, 0f);
				BoxCollider2D weaponBox = weaponComponentReal.AddComponent<BoxCollider2D>();
				weaponBox.size = wsr.size;
				weaponComponentReal.layer = LayerMask.NameToLayer("Player");
				weaponComponentReal.tag = "Player";
				weaponComponentReal.transform.SetParent(temp.transform);
				weaponComponentReal.transform.SetAsLastSibling();

				if (uiChild.GetComponent<RedBlock>() != null)
				{
					weaponComponentReal.AddComponent<RedBlock>();
				}
				if (uiChild.GetComponent<BlueBlock>() != null)
				{
					weaponComponentReal.AddComponent<BlueBlock>();
				}
				if (uiChild.GetComponent<YellowBlock>() != null)
				{
					weaponComponentReal.AddComponent<YellowBlock>();
				}
			}
		}

		//finally scale down weapon to fit.
		temp.transform.SetParent(weapon.transform);
		temp.transform.localPosition = new Vector3(0f, 0f, 0f);
		temp.transform.localScale = new Vector3(weaponScaling, weaponScaling);
		temp.tag = "Player";
		temp.layer = LayerMask.NameToLayer("Player");
		temp.transform.localRotation = Quaternion.Euler(0, 0, 270);
		weapon.transform.localPosition = new Vector3(0, 0, 0);
		weapon.SetActive(true);
		Time.timeScale = 1f;
		this.gameObject.SetActive(false);
	}

	public void ClearWeapon()
	{
		foreach (GameObject o in pieces)
		{
			Destroy(o);
		}
		pieces.Clear();
	}

	private bool CheckValidWeapon()
	{
		// check intersections with 
		List<RectTransform> validPieces = new List<RectTransform> { hilt.GetComponent<RectTransform>() };
		List<RectTransform> piecesToCheck = new List<RectTransform>();
		foreach(GameObject piece in pieces)
		{
			piecesToCheck.Add(piece.GetComponent<RectTransform>());
		}
		bool foundDifference = true;
		while(foundDifference)
		{
			foundDifference = false;
			List<RectTransform> tempPieceToCheck = new List<RectTransform>(piecesToCheck);
			List<RectTransform> tempValidPieces = new List<RectTransform>(validPieces);
			foreach (RectTransform piece in piecesToCheck)
			{
				foreach (RectTransform validPiece in validPieces)
				{
					if (!piece.Equals(validPiece))
					{
						Rect rect1 = new Rect(piece.localPosition.x - piece.rect.width / 2f, 
												piece.localPosition.y - piece.rect.height / 2f,
												piece.rect.width, 
												piece.rect.height);
						Rect rect2 = new Rect(validPiece.localPosition.x - validPiece.rect.width / 2f, 
												validPiece.localPosition.y - validPiece.rect.height / 2f,
												validPiece.rect.width, 
												validPiece.rect.height);
						if (rect1.Overlaps(rect2))
						{
							tempValidPieces.Add(piece);
							tempPieceToCheck.Remove(piece);
							foundDifference = true;
						}
					}
				}
			}
			piecesToCheck = tempPieceToCheck;
			validPieces = tempValidPieces;
		}
		return piecesToCheck.Count == 0;
	}

	private IEnumerator ShowErrorText(string text, float duration)
	{
		errorTextBox.text = text;
		errorTextBox.color = new Color32(178, 71, 18, 255);
		errorTextBox.gameObject.SetActive(true);
		// hold text on screen.
		yield return new WaitForSecondsRealtime(duration);

		// fade out text.
		float elapsedTime = 0f;
		float fadeOutDuration = 0.5f;
		while (elapsedTime < fadeOutDuration)
		{
			elapsedTime += 0.01f;
			errorTextBox.color = Color32.Lerp(new Color32(178, 71, 18, 255), new Color32(178, 71, 18, 0), elapsedTime / fadeOutDuration);
			yield return new WaitForSecondsRealtime(0.01f);
		}
		errorTextBox.gameObject.SetActive(false);
	}
}

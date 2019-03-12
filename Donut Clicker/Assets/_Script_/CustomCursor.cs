using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour
{
	[HideInInspector]
	public Image imageComponent;
	Camera cam;

	static public CustomCursor get = null;

	// Start is called before the first frame update
	void Awake()
	{
		get = this;
		imageComponent = GetComponent<Image>();
		cam = Camera.main;
		Cursor.visible = false;
	}

	private void Update()
	{
		//Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
		Vector3 pos = Input.mousePosition;
		transform.position = pos;
	}

	private void OnDestroy()
	{
		Cursor.visible = true;
	}
}

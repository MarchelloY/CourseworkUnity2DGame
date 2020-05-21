using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public Sprite l1, l2;
	private BoxCollider2D box;
	private int count = 0;

	private void Awake()
	{
		box=GetComponent<BoxCollider2D>();
	}
	public void OnMouseDown()
	{
		if(GameObject.Find("Pocket").GetComponent<Key>().keyActive)
		{
		if (count % 2 == 0) {
			GameObject.Find("Door").GetComponent<SpriteRenderer> ().sprite = l1;
			box.isTrigger = true;
		}
		if (count % 2 == 1) {
			GameObject.Find("Door").GetComponent<SpriteRenderer> ().sprite = l2;
			box.isTrigger = false;
		}
		count++;
		}
	}
}

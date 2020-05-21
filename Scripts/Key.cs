using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	public Sprite l1;
	public bool keyActive;
	private void OnMouseDown()
	{
		if (GameObject.Find ("Socket").GetComponent<SwitchPC> ().pcActive) {
			keyActive = true;
			GameObject.Find ("Key").GetComponent<SpriteRenderer> ().sprite = l1;
		}
	}
}

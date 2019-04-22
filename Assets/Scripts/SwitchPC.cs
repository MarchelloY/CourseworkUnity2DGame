using System.Collections;
using UnityEngine;

public class SwitchPC : MonoBehaviour {
	public Sprite l1, l2, l3;
	public bool pcActive=false;

	private void OnMouseDown()
	{
		if (!pcActive) {
			GameObject.Find("Socket").GetComponent<SpriteRenderer> ().sprite = l3;
			GameObject.Find("Light").GetComponent<SpriteRenderer> ().sprite = l2;
		}
		if (pcActive) {
			GameObject.Find("Socket").GetComponent<SpriteRenderer> ().sprite = l1;
			GameObject.Find("Light").GetComponent<SpriteRenderer> ().sprite = l3;
		}
		pcActive = !pcActive;
	}
}

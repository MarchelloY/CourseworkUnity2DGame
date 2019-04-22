using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
	public Sprite l1, l2;

	private void OnMouseOver ()
	{
		if(!GameObject.Find("Shield").GetComponent<Electric>().electric){
		GameObject.Find ("Hole").GetComponent<SpriteRenderer> ().sprite = l1;
		Earthquake.Shake (0.1F, 0.1F);
		}
    }
	private void OnMouseExit ()
	{
		GameObject.Find ("Hole").GetComponent<SpriteRenderer> ().sprite = l2;
	}
}

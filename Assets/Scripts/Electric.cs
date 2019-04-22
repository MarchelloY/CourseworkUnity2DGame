using System.Collections;
using UnityEngine;

public class Electric : MonoBehaviour {
	public Sprite l1,l2;
	private Animator animator;
	public bool electric;

	public void Awake()
	{
		animator = GameObject.Find("Flash").GetComponent<Animator>();
		State = CharState.FlashWire;
	}
	public CharState State
	{
		get{return (CharState)animator.GetInteger ("State");}
		set{animator.SetInteger ("State", (int)value);}
	}
	public void OnMouseDown()
	{
		GameObject.Find ("WireUp").GetComponent<SpriteRenderer> ().sprite = l1;
		GameObject.Find ("WireDown").GetComponent<SpriteRenderer> ().sprite = l2;
		State = CharState.FlashWater;
		electric = true;
	}
	public enum CharState
	{
		FlashWire,
		FlashWater
	}
}

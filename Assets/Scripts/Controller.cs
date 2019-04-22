using System.Collections;
using UnityEngine;

public class Controller : MonoBehaviour {
	public float speed = 3.0F; 
	public float jumpForce = 15.0F;
	public float radius = 3.0F;
	public bool isGrounded = false;
	private Rigidbody2D rb2d;
	private Animator animator;
	private SpriteRenderer sprite;

	private CharState State
	{
		get{return (CharState)animator.GetInteger ("State");}
		set{animator.SetInteger ("State", (int)value);}
	}
	private void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		sprite = GetComponentInChildren<SpriteRenderer>();
	}
	private void FixedUpdate()
	{
		CheckGround ();
		State = CharState.Idle;
		if (Input.GetButton ("Horizontal"))
			Run ();
		if (isGrounded && Input.GetButtonDown ("Jump"))
			Jump ();
	}
	private void Run()
	{
		Vector3 direction = transform.right * Input.GetAxis ("Horizontal");
		transform.position = Vector3.MoveTowards (transform.position, transform.position + direction, speed * Time.deltaTime);
		sprite.flipX = direction.x < 0.0F;
		State = CharState.Run;
	}
	private void Jump()
	{
		State = CharState.Run;
		rb2d.AddForce (transform.up * jumpForce,ForceMode2D.Impulse);
	}
	private void CheckGround()
	{
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, radius);
		isGrounded = colliders.Length > 1;
	}
}
public enum CharState
{
	Idle,
	Run
}
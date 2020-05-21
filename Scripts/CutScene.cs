using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour {
	public Sprite l0,l1,l2,l3,l4,l5;
	private int count = 0;

	private void Start()
	{
		GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l0;
	}
	private void OnMouseDown()
	{
		if(count==0) GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l1;
		if(count==1) GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l2;
		if(count==2) GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l3;
		if(count==3) GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l4;
		if(count==4) GameObject.Find("Comics").GetComponent<SpriteRenderer> ().sprite = l5;
		if(count==5) SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
		count++;
	}
}

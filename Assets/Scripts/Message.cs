using UnityEngine;

public class Message: MonoBehaviour {
	public Sprite l1, l2;
	public bool inTrigger = false; 
	private string text;

	private void Update()
	{
		//ROOM
		if (name.Equals ("Poster")) text = "ПЕСИКПЕСИКПЕСИКПЕСИКПЕСИКПЕСИК!!";
		if (name.Equals ("Cactus")) text = "Здесь должен быть другой кактус((";
		if (name.Equals ("Socket") && (GameObject.Find("Socket").GetComponent<SwitchPC>().pcActive)) text = "Выключить копьютер";
		if (name.Equals ("Socket") && !(GameObject.Find("Socket").GetComponent<SwitchPC>().pcActive)) text = "Включить копьютер";
		if (name.Equals ("Pocket") && !GameObject.Find("Pocket").GetComponent<Key>().keyActive && !GameObject.Find ("Socket").GetComponent<SwitchPC> ().pcActive) text = "Ничего не видно";
		if (name.Equals ("Pocket") && !GameObject.Find("Pocket").GetComponent<Key>().keyActive && GameObject.Find ("Socket").GetComponent<SwitchPC> ().pcActive) text = "Забрать ключ";
		if (name.Equals ("Pocket") && GameObject.Find("Pocket").GetComponent<Key>().keyActive) text = "Брать больше нечего";
		if (name.Equals ("Door") && !GameObject.Find("Pocket").GetComponent<Key>().keyActive) text = "Нужно найти ключ";
		if (name.Equals ("Door") && GameObject.Find("Pocket").GetComponent<Key>().keyActive && GameObject.Find("Door").GetComponent<BoxCollider2D>().isTrigger) text = "Закрыть дверь";
		if (name.Equals ("Door") && GameObject.Find("Pocket").GetComponent<Key>().keyActive && !GameObject.Find("Door").GetComponent<BoxCollider2D>().isTrigger) text = "Открыть дверь";
		//UNDERGROUND
		if (name.Equals ("Hole") && !GameObject.Find("Shield").GetComponent<Electric>().electric) text = "Лучше мне отойти";
		if (name.Equals ("Hole") && GameObject.Find("Shield").GetComponent<Electric>().electric) text = "Забрать проездной";
		if (name.Equals ("Scoreboard")) text = "Нужен проездной";
		if (name.Equals ("Marchello")) text = "Он главный в этом городе";
		if (name.Equals ("Shield") && !GameObject.Find("Shield").GetComponent<Electric>().electric) text = "Положить провод в воду";
		if (name.Equals ("Shield") && GameObject.Find("Shield").GetComponent<Electric>().electric) text = "Больше не прикоснусь";
	}
	private void OnGUI ()
	{ 
		if (inTrigger) 
		{
			GUI.color = Color.black;
			GUI.Label (new Rect (Screen.width/24, Screen.height/18, 300, 30), text);
			if (name.Equals ("Poster"))Earthquake.Shake (0.1F, 0.1F);
		}
	}
	private void OnMouseOver() 
	{
		inTrigger = true; 
		GameObject.Find("Table").GetComponent<SpriteRenderer> ().sprite = l1;
	}
	private void OnMouseExit() 
	{
		inTrigger = false;
		GameObject.Find("Table").GetComponent<SpriteRenderer> ().sprite = l2;
	}
}

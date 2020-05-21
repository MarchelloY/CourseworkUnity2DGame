using System.Collections;
using UnityEngine.SceneManagement;

using UnityEngine;

public class PrevScene : MonoBehaviour {
	void OnCollisionEnter2D(){
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex-1);
	}
}

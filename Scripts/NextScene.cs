using System.Collections;
using UnityEngine.SceneManagement;

using UnityEngine;

public class NextScene : MonoBehaviour {
	void OnCollisionEnter2D(){
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
	}
}

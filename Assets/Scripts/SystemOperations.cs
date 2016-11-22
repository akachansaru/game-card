using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SystemOperations : MonoBehaviour {

	public static SystemOperations systemOperations;

	void Start() {
		systemOperations = this;
	}

	public void QuitGame () {
		Application.Quit ();
	}

	public void QuitButton () {
		Invoke ("QuitGame", 0.5f);
	}

	public void LoadNextLevel(float delay) {
		Invoke ("Load", delay);
	}

	void Load() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
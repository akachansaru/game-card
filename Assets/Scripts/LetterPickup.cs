using UnityEngine;
using System.Collections;

public class LetterPickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			gameObject.SetActive(false);

			// If there are no more letters in the scene, switch to next scene
			if (GameObject.FindGameObjectsWithTag("Letter").Length == 0) {
				SystemOperations.systemOperations.LoadNextLevel(0.5f);
			}
		}
	}
}

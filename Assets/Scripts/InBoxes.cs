using UnityEngine;
using System.Collections;

public class InBoxes : MonoBehaviour {

	public static InBoxes inBoxes;

	public int totBoxCount;

	private int inBoxCount;
	private SpriteRenderer background;
	private float timestamp = 0.0f;

	void Start () {
		inBoxes = this;
		background = GetComponent<SpriteRenderer> ();
		inBoxCount = 0;
	}

	void CheckLevelWon () {
		if (inBoxCount == totBoxCount) {
			if (Time.time >= timestamp) {
				background.color = new Color(Random.value, Random.value, Random.value);
				timestamp = Time.time + 1.0f;
			}
			SystemOperations.systemOperations.LoadNextLevel(2f);
		}
	}

	void Update () {
		CheckLevelWon ();
	}
	
	public void IncBoxCount() {
		inBoxCount++;
	}

	public void DecBoxCount() {
		inBoxCount--;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoxTouching : MonoBehaviour {
	public string boxLetter;

	private Image image;

	void Start () {
		image = GetComponent<Image> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("In Box");
		if (other.gameObject.GetComponent<DragLetter>().letter == boxLetter) {
			Debug.Log ("In Box");
			InBoxes.inBoxes.IncBoxCount();
			image.color = Color.green;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.GetComponent<DragLetter>().letter == boxLetter) {
			InBoxes.inBoxes.DecBoxCount();
			image.color = Color.white;
		}
	}
}
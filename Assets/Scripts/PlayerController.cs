using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;

	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	public void MoveLeft () {
		rb.velocity = Vector2.left * speed;
	}

	public void MoveRight () {
		rb.velocity = Vector2.right * speed;
	}

	public void Jump () {
		rb.velocity = new Vector2(rb.velocity.x, speed + 2);
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			MoveLeft ();
		} 
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			MoveRight ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Jump ();
		}
	}
}

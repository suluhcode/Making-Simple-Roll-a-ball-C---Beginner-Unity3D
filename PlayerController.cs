using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;// for speed of cube moving
	private int count;
	public GUIText countText;
	public GUIText winText;

	void start() {
		count = 0;
		SetCountText();
		winText.text = "";
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);//create new vector for movement, no y axis

		rigidbody.AddForce (movement * speed * Time.deltaTime); movement ball with rigidbody
	}	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {// set unactive when collider
			other.gameObject.SetActive(false);// disable collected object
			count = count + 1;
			SetCountText();
		}
	}
	void SetCountText() {
		countText.text = "Collected Box : " + count.ToString ();
		if (count >= 11) {
			winText.text = "YOU WIN!!!";
		}
	}
}	

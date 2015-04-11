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

	void FixedUpdate() {\
		//define the direction ball move
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		//create new vector for movement, no y axis
		Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
		//use rigidbody for speeding the ball
		rigidbody.AddForce (movement * speed * Time.deltaTime); movement ball with rigidbody
	}	
	//use function method OnTriggerEnter for trigger the collected box
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

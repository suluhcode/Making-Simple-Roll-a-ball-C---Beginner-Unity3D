using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;// for place player object
	private Vector3 offset;// ofset of camera

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;// camera follow player object with offset
	}
}

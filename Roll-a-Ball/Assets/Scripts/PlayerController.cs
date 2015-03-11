using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; // can edited in the Unity Editor

	// Update is called once per frame
	void Update () {
	
	}

	// called before physics update
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical"); 

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical); 
		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
		// multiplying by Time.deltaTime makes it smooth
	} 
}

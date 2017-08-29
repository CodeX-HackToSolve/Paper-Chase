using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public float speed;
	public float jump;
	float moveVelocity;
	bool grounded = false;


	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved ) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
		}
	
	}
	

}

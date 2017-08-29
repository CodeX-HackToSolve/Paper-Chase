using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float speed = -5f;
	public GameObject obj1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveImage ();
	}

	void moveImage(){
		transform.Translate (-speed * Time.deltaTime, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "FrontCollider") {
			Instantiate (gameObject, obj1.transform.position, Quaternion.identity);
			Destroy (gameObject, 1f);
		}
	}
}

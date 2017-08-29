using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollitionEnter : MonoBehaviour {

	// GameObject gameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		// Destroy (gameObject);
		if (col.gameObject.name == "Andy") {
			//GameObject.Find("Steen 01").transform.localScale = new Vector3(0,0,0);
			//StartCoroutine(Example());
			Application.LoadLevel(Application.loadedLevel);

		}

		//IEnumerator Example()
		//{
		//yield return new WaitForSeconds(0.5f);
		//Application.LoadLevel(Application.loadedLevel);
		//Debug.Log("hi");
		//}
		// gameObject.collider.active = false;
		Debug.Log("fasie");

		//transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
	}
}

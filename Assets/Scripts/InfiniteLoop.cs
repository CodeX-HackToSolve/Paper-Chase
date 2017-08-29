using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteLoop : MonoBehaviour {

	public float scrollSpeed = -20f;
	Vector2 startpos;

	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		float newPos = Mathf.Repeat (Time.time * scrollSpeed, 20);
		transform.position = startpos + Vector2.right * newPos;
	}
}

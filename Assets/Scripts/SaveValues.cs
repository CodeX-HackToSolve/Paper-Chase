using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValues : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetFloat("Spaarrekening", 0.0F);
		PlayerPrefs.SetFloat("Rente", 0.0F);
		PlayerPrefs.SetFloat("Zakgeld", 0.0F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

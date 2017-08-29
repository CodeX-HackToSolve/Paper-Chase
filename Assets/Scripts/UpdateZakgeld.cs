using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateZakgeld : MonoBehaviour {

	public Text Zakgeld;

	// Use this for initialization
	void Start () {
		Zakgeld.text = PlayerPrefs.GetFloat("Zakgeld").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

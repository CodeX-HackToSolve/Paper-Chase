using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpdateZakgeld : MonoBehaviour {

	public Text OldScoreValue;
	public Text levelScore; // display text
	// actual value
	public Text newScoreValue; 
	private float finalScoreValue;

	// Use this for initialization
	void Start () {
		updateScore (200);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void updateScore(float levelScoreValue){
		// get old value
		OldScoreValue.text = PlayerPrefs.GetFloat ("Zakgeld").ToString ();

		// set levelscore
		levelScore.text = levelScoreValue.ToString();

		// cal finalscore
		finalScoreValue = PlayerPrefs.GetFloat ("Zakgeld") + levelScoreValue;

		// set finalscore
		newScoreValue.text = finalScoreValue.ToString();

		// store finalscore to zakgeld
		PlayerPrefs.SetFloat("Zakgeld", finalScoreValue);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bankScript : MonoBehaviour {

	[SerializeField]
	private Text txtZakGeld = null;

	[SerializeField]
	private Text txtSpaarGeld = null;

	[SerializeField]
	private Text txtRente = null;

	// Use this for initialization
	void Start () {
		//PlayerPrefManager.setZakGeld (100f);
		//PlayerPrefManager.setSpaarGeld (0f);
		//PlayerPrefManager.setRente (0f);
		//PlayerPrefManager.setPlayerLevel(1f);

		txtZakGeld.text = PlayerPrefManager.getZakGeld ().ToString();
		txtSpaarGeld.text = PlayerPrefManager.getSpaarGeld ().ToString();
		txtRente.text = PlayerPrefManager.getRente ().ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void upgradeRente(){
		if (PlayerPrefManager.upGradeRente () == 1) {
			txtRente.text = PlayerPrefManager.getRente ().ToString();
			return;
		}

		Debug.Log ("Max Rente Reached");
	}

	public void sparen(){
		if (PlayerPrefManager.zakToSpaarGeld () == 1) {
			txtZakGeld.text = PlayerPrefManager.getZakGeld ().ToString();
			txtSpaarGeld.text = PlayerPrefManager.getSpaarGeld ().ToString();
			return;
		}

		Debug.Log ("Insufficient zakgeld");
	}

	public void opnemen(){
		if (PlayerPrefManager.spaarToZakGeld () == 1) {
			txtSpaarGeld.text = PlayerPrefManager.getSpaarGeld ().ToString();
			txtZakGeld.text = PlayerPrefManager.getZakGeld ().ToString();
			return;
		}

		Debug.Log ("Insufficient spaargeld");
	}

}

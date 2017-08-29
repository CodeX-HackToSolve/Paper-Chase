using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour {

	//float values
	const string ZAKGELD = "zakgeld";
	const string SPAARGELD = "spaargeld";
	const string RENTE = "rente";
	const string MAX_LEVEL = "max_level";


	//options
	//--------------------------

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void setRente(float rente){
		PlayerPrefs.SetFloat (RENTE, rente);
	}

	public static void setPlayerLevel(float level){
		PlayerPrefs.SetFloat (MAX_LEVEL, level);
	}

	public static float getPlayerLevel(){
		return PlayerPrefs.GetFloat (MAX_LEVEL);
	}

	public static float getZakGeld(){
		return PlayerPrefs.GetFloat (ZAKGELD);
	}

	public static void setZakGeld(float amount){
		PlayerPrefs.SetFloat (ZAKGELD, amount);
	}

	public static float getSpaarGeld(){
		return PlayerPrefs.GetFloat (SPAARGELD);
	}

	public static void setSpaarGeld(float amount){
		PlayerPrefs.SetFloat (SPAARGELD, amount);
	}

	public static float getRente(){
		return PlayerPrefs.GetFloat (RENTE);
	}

	public static int upGradeRente(){
		float currentRente = getRente ();

		print (getPlayerLevel ());

		if (currentRente == 0 && (getPlayerLevel() == 1f)) {
			PlayerPrefs.SetFloat (RENTE, 1.5f);
			return 1;
		}

		if (currentRente == (float)1.5 && (getPlayerLevel() == 2f)) {
			PlayerPrefs.SetFloat (RENTE, 3f);
			return 1;
		}

		if (currentRente == (float)3 && (getPlayerLevel() == 4f)) {
			PlayerPrefs.SetFloat (RENTE, 5f);
			return 1;
		}

		if (currentRente == (float)5) {
			return 0;
		}

		return 0;
	}

	public static int zakToSpaarGeld(){
		if (getZakGeld () > (float)10) {
			setZakGeld (getZakGeld () - (float)10);
			setSpaarGeld (getSpaarGeld () + (float)10);
			return 1;
		} else {
			Debug.Log("insuffecient zakgeld, must be at least 10");
			return 0;
		}
	}

	public static int spaarToZakGeld(){
		if (getSpaarGeld () > (float)50) {
			setSpaarGeld (getSpaarGeld () - (float)10);
			setZakGeld (getZakGeld () + (float)10);
			print ("zakgeld" + getZakGeld ());
			return 1;
		} else {
			Debug.Log("insuffecient spaargeld, must be at least 50");
			return 0;
		}
	}
}

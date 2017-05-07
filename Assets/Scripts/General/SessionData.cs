using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton Class
public class SessionData : MonoBehaviour {

	public static SessionData Instance;

	public string aircraftNumber;

	void Awake(){

		if (Instance == null) {
			Instance = this;
		} else if(Instance != this){
			Destroy (gameObject);
		}

		// don't destroy this object when a new Scene is loaded
		DontDestroyOnLoad (gameObject);

	}
}

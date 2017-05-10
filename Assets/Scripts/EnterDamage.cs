using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour {

	private string NEW_DAMAGE_LABEL = "New Damage";
	private string CLOSE_LABEL = "Close";
	public GameObject theCanvas;


	public void onClick(){
		Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
		if (ButtonsText[0].text == CLOSE_LABEL) {
			ButtonsText[0].text = NEW_DAMAGE_LABEL;
		} else {
			ButtonsText[0].text = CLOSE_LABEL;
		}
	}
}

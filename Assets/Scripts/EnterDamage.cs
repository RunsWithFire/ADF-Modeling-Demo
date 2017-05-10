using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour {

	public string NEW_DAMAGE_LABEL = "New Damage";
	public string CLOSE_LABEL = "Close";
	public GameObject theCanvas;
	private Animator slideInAnimation;

	public void Start(){
		Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
		ButtonsText[0].text = NEW_DAMAGE_LABEL;
	}

	public void onClick(){
		getAnimator (theCanvas);
		Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
		if (ButtonsText[0].text == CLOSE_LABEL) {
			ButtonsText[0].text = NEW_DAMAGE_LABEL;
			slideInAnimation.enabled = true;
			slideInAnimation.Play("SlideDamageEntryCanvasOut");

		} else {
			ButtonsText[0].text = CLOSE_LABEL;
			slideInAnimation.enabled = true;
			slideInAnimation.Play("SlideDamageEntryCanvasIn");
		}
	}


	void getAnimator(GameObject theCanv){
		if (slideInAnimation == null) {
			slideInAnimation = theCanvas.GetComponent<Animator>();
		}


	}
}

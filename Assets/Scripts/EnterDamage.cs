using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour
{

    private string NEW_DAMAGE_LABEL = "New Damage";
    private string CLOSE_LABEL = "Complete";
    public GameObject theCanvas;
    public GameObject stateMachine;
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
            stateMachine.GetComponent<stateMachineController>().state = "ViewAircraft";

        } else {
			ButtonsText[0].text = CLOSE_LABEL;
			slideInAnimation.enabled = true;
			slideInAnimation.Play("SlideDamageEntryCanvasIn");
            stateMachine.GetComponent<stateMachineController>().state = "CreateDamage";
        }
	}


	void getAnimator(GameObject theCanv){
		if (slideInAnimation == null) {
			slideInAnimation = theCanvas.GetComponent<Animator>();
		}


	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour
{

<<<<<<< HEAD
    private string NEW_DAMAGE_LABEL = "New Damage";
    private string CLOSE_LABEL = "Close";
    public GameObject theCanvas;
    public GameObject stateMachine;
=======
	public string NEW_DAMAGE_LABEL = "New Damage";
	public string CLOSE_LABEL = "Close";
	public GameObject theCanvas;
	private Animator slideInAnimation;
>>>>>>> refs/remotes/origin/Brent-ADF-Branch

	public void Start(){
		Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
		ButtonsText[0].text = NEW_DAMAGE_LABEL;
	}

<<<<<<< HEAD
    public void onClick()
    {
        Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
        if (ButtonsText[0].text == CLOSE_LABEL)
        {
            ButtonsText[0].text = NEW_DAMAGE_LABEL;
            stateMachine.GetComponent<stateMachineController>().state = "ViewAircraft";
        }
        else
        {
            ButtonsText[0].text = CLOSE_LABEL;
            stateMachine.GetComponent<stateMachineController>().state = "CreateDamage";
        }
    }
=======
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
>>>>>>> refs/remotes/origin/Brent-ADF-Branch
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour {

<<<<<<< HEAD
    public GameObject stateMachine;
=======
	private string NEW_DAMAGE_LABEL = "New Damage";
	private string CLOSE_LABEL = "Close";
>>>>>>> refs/remotes/origin/Brent-ADF-Branch
	public GameObject theCanvas;


	public void onClick(){
<<<<<<< HEAD
		if (theCanvas.activeSelf) {
			theCanvas.SetActive(false);
			Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
			ButtonsText[0].text = "New Damage";

            stateMachine.GetComponent<stateMachineController>().state = "CreateDamage";
            print(stateMachine.GetComponent<stateMachineController>().state);
        } else {
			
			theCanvas.SetActive(true);
			Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
			ButtonsText[0].text = "Close";

            stateMachine.GetComponent<stateMachineController>().state = "ViewAircraft";
            print(stateMachine.GetComponent<stateMachineController>().state);
        }

        
    }

    
    
=======
		Text[] ButtonsText = GetComponentsInChildren<UnityEngine.UI.Text>();
		if (ButtonsText[0].text == CLOSE_LABEL) {
			ButtonsText[0].text = NEW_DAMAGE_LABEL;
		} else {
			ButtonsText[0].text = CLOSE_LABEL;
		}
	}
>>>>>>> refs/remotes/origin/Brent-ADF-Branch
}

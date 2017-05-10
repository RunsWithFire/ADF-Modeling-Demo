using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDamage : MonoBehaviour {

    public GameObject stateMachine;
	public GameObject theCanvas;


	public void onClick(){
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

    
    
}

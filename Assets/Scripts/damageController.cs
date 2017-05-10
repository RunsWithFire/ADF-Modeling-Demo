using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageController : MonoBehaviour {

    public GameObject stateMachine;
    public GameObject damage;

	// Use this for initialization
	void Start () {
        stateMachine = GameObject.Find("StateMachine");
	}
	
	// Update is called once per frame
	void Update () {
        
        // If click on Damage ball.
		if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.Contains("Damage"))
                {
                    stateMachine.GetComponent<stateMachineController>().state = "ViewDamage";
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (stateMachine.GetComponent<stateMachineController>().state.Equals("CreateDamage")) {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name.Contains("B747"))
                    {
                        Instantiate(damage, hit.point, new Quaternion());
                    }
                }
            }
        }
	}
}

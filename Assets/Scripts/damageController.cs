using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageController : MonoBehaviour {

    public GameObject stateMachine;

    public string damageType;
    public string height;
    public string width;

	// Use this for initialization
	void Start () {
        stateMachine = GameObject.Find("StateMachine");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.Equals("Damage"))
                {
                    stateMachine.GetComponent<stateMachineController>().state = "ViewDamage";
                }
            }
        }
	}
}

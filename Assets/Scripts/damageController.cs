using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageController : MonoBehaviour {

    public GameObject stateMachine;
    public GameObject damage;

    private GameObject newDamage;
    public Dropdown dropdown;

    public Material scratchDamage;
    public Material dentDamage;
    public Material gashDamage;
    public Material divotDamage;
    public Material lightningDamage;

	// Use this for initialization
	void Start () {
        stateMachine = GameObject.Find("StateMachine");
	}
	
	// Update is called once per frame
	void Update () {
        moveToViewDamage();
        createDamage();
        moveDamage();
        newDamageColorUpdate();
	}

    // If you click on a ball while in Aircraft Viewer mode.
    public void moveToViewDamage()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stateMachine.GetComponent<stateMachineController>().state.Equals("ViewAircraft"))
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
        }
    }

    // If you are in the create damage menu and you click on the aircraft.
    public void createDamage()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stateMachine.GetComponent<stateMachineController>().state.Equals("CreateDamage"))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name.Contains("B747"))
                    {
                        newDamage = Instantiate(damage, hit.point, new Quaternion());
                        newDamage.transform.parent = GameObject.Find("B-747").transform;

                        stateMachine.GetComponent<stateMachineController>().state = "MoveDamage";
                    }
                }
            }
        }
    }

    // If the user is still creating damage, but wants to move it's location.
    public void moveDamage()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stateMachine.GetComponent<stateMachineController>().state.Equals("MoveDamage"))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name.Contains("B747"))
                    {
                        newDamage.transform.position = hit.point;
                    }
                }
            }
        }
    }

    // Makes sure the new damage is the proper color.
    public void newDamageColorUpdate()
    {
        if (stateMachine.GetComponent<stateMachineController>().state.Equals("MoveDamage"))
        {
            int dropdownValue =  dropdown.GetComponent<Dropdown>().value;
            switch (dropdownValue)
            {
                case 0:
                    newDamage.GetComponent<Renderer>().material = scratchDamage;
                    break;
                case 1:
                    newDamage.GetComponent<Renderer>().material = dentDamage;
                    break;
                case 2:
                    newDamage.GetComponent<Renderer>().material = gashDamage;
                    break;
                case 3:
                    newDamage.GetComponent<Renderer>().material = divotDamage;
                    break;
                case 4:
                    newDamage.GetComponent<Renderer>().material = lightningDamage;
                    break;
            }
        }
    }
}

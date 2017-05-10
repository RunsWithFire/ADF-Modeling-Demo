using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDamageController : MonoBehaviour {
	//animator reference
	private Animator anim;
	bool DamageEditActive = false;
	// Use this for initialization
	void Start () {

		Time.timeScale = 1;
		//get the animator component
		anim = gameObject.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		anim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//function to pause the game
	public void SlideIn(){
		//enable the animator component
		anim.enabled = true;
		//play the Slidein animation
		anim.Play("SlideDamageEntryCanvasIn");


		//freeze the timescale
		Time.timeScale = 0;
	}
	//function to unpause the game
	public void SlideOut(){

		//play the SlideOut animation
		anim.Play("SlideDamageEntryCanvasOut");
		//set back the time scale to normal time scale
		Time.timeScale = 1;
	}

}

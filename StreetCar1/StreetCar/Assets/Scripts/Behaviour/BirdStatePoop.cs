﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using BehaviourMachine;

public class BirdStatePoop : StateBehaviour
{
	// Called when the state is enabled
	void OnEnable () {
		Debug.Log("Started *State*");
	}
 
	// Called when the state is disabled
	void OnDisable () {
		Debug.Log("Stopped *State*");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


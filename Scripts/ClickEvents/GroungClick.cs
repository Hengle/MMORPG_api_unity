﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroungClick : MonoBehaviour {

    public GameObject gameUser;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void NazhalCallBack (Vector3 pos) {
        var posToNavigate = gameUser.GetComponent<PositionNavigator>();
        // Sending pos to PositionNavigator
        posToNavigate.PlayerNavigation(pos);

    }
}
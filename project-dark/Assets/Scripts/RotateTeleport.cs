﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTeleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 30 * Time.deltaTime, 0);
    }
}

﻿using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * 50 * Time.deltaTime;
    }
}

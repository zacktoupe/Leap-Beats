using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    GameObject manager;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("Manager");
	}
	
	// Update is called once per frame
	void Update () {
        if (manager.GetComponent<DrumManager>().GetDrumHit("red"))
            Debug.Log("red");
        if (manager.GetComponent<DrumManager>().GetDrumHit("green"))
            Debug.Log("green");
        if (manager.GetComponent<DrumManager>().GetDrumHit("blue"))
            Debug.Log("blue");
        if (manager.GetComponent<DrumManager>().GetDrumHit("orange"))
            Debug.Log("orange");
    }
}

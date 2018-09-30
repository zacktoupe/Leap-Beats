using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumManager : MonoBehaviour {

    private GameObject red;
    private GameObject green;
    private GameObject blue;
    private GameObject orange;

    // Use this for initialization
    void Start () {
        red = GameObject.FindGameObjectWithTag("Red");
        green = GameObject.FindGameObjectWithTag("Green");
        blue = GameObject.FindGameObjectWithTag("Blue");
        orange = GameObject.FindGameObjectWithTag("Orange");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public bool GetDrumHit(string color)
    {
        switch (color)
        {
            case "red":
                if (red.GetComponent<DrumCollider>().IsActive)
                {
                    red.GetComponent<DrumCollider>().IsActive = false;
                    return true;
                }
                break;
            case "green":
                if (green.GetComponent<DrumCollider>().IsActive)
                {
                    green.GetComponent<DrumCollider>().IsActive = false;
                    return true;
                }
                break;
            case "blue":
                if (blue.GetComponent<DrumCollider>().IsActive)
                {
                    blue.GetComponent<DrumCollider>().IsActive = false;
                    return true;
                }
                break;
            case "orange":
                if (orange.GetComponent<DrumCollider>().IsActive)
                {
                    orange.GetComponent<DrumCollider>().IsActive = false;
                    return true;
                }
                break;
            default:
                throw new ArgumentException("Daniel must have messed something up.");
        }

        return false;
    }
}

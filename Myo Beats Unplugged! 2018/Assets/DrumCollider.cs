using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumCollider : DrumManager {
    private bool reactivate;

    public bool IsActive { get; set; }

    // Use this for initialization
    void Start () {
        IsActive = false;
        reactivate = true;
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "palm" && reactivate)
        {
            IsActive = true;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.FindGameObjectWithTag("Manager").GetComponent<DrumManager>().GetDrumHit("orange") && active == true)
        {
            Destroy(note);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if(collision.gameObject.tag == "note")
        {
            note = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}

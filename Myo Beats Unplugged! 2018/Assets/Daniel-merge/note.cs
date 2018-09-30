using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class note : MonoBehaviour {

    Rigidbody2D rb;
    public float speed = 10F;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
        rb.velocity = new Vector2(0, -speed); // x, y
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

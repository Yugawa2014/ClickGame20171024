﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Use this for initialization
    void Start () {
        //Shoot(new Vector3(0, 200, 2000));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

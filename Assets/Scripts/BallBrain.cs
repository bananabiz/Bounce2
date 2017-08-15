using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBrain : MonoBehaviour {
    Rigidbody rigi;
	// Use this for initialization
	void Start () {
        rigi = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "bounce")
        { 
        print("Hello!");
        rigi.velocity = ((transform.position - collision.contacts[0].point) * 50);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetoid : MonoBehaviour {
    Rigidbody rigi;
    Transform sun;
    GameObject[] gravitys;
	// Use this for initialization
	void Start () {
        rigi = GetComponent<Rigidbody>();
        sun = GameObject.Find("Sun").transform;
        gravitys = GameObject.FindGameObjectsWithTag("Gravity");
        //rigi.velocity = (Vector3.right + Vector3.forward) *10;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        for (int i = 0; i < gravitys.Length; i++)
        {
            rigi.AddForce(((gravitys[i].transform.position - transform.position) * 20 / (Vector3.Distance(transform.position, gravitys[i].transform.position) * 10)) * gravitys[i].transform.localScale.x);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehavior : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveh = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveh, 0.0f, movev);
        rb.AddForce(move * speed);
    }
}

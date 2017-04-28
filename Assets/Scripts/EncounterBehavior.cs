using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterBehavior : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
    void OnTriggerExit(Collider other)
    {
        
    }



	// Update is called once per frame
	void Update () {
		
	}
}

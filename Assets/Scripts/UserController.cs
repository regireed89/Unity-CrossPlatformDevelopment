using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour {
    class Player
    {
        Player() { }
        private Vector2 position = new Vector2(0, 0);
        private int health = 100;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour {


    public List<GameObject> boxes;

    public GameObject boxPrefab;

	// Use this for initialization
	void Start ()
    {
        boxes = new List<GameObject>();
	}
	
	void Update()
    {
        GameObject box;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            box = Instantiate(boxPrefab) as GameObject;
            boxes.Add(box);
        }
    }
}

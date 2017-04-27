using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Grid : MonoBehaviour
{

    Vector2 position = new Vector2();
    Vector2 keypos = new Vector2();
    Vector2 exitpos = new Vector2();
    List<Node> grid;
    bool gotkey = false;
    
    struct Node
    {
        public Vector2 node;
        public GameObject quad;
    }
    // Use this for initialization
    void Start()
    {

        grid = new List<Node>();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Node newNode = new Node();
                newNode.node = new Vector2(i, j);
                newNode.quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
                newNode.quad.GetComponent<Renderer>().material.color = Color.black;
                newNode.quad.transform.localScale = new Vector3(1, 1, 1);
                newNode.quad.transform.position = newNode.node;
                grid.Add(newNode);
            }
        }
        position = grid[Random.Range(0, 24)].node;
        keypos = grid[Random.Range(0, 24)].node;
        exitpos = grid[Random.Range(0, 24)].node;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position.y += 1;
            Debug.Log(position);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position.y -= 1;
            Debug.Log(position);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position.x += 1;
            Debug.Log(position);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position.x -= 1;
            Debug.Log(position);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("TBAG");
        }
        foreach (Node n in grid)
        {
            if (position == n.node)
            {
                n.quad.GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                n.quad.GetComponent<Renderer>().material.color = Color.black;
            }

            if (position == keypos)
            {
                gotkey = true;
                n.quad.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.Log("you found the key ");
            }

            if (position == exitpos && gotkey == true)
            {
                n.quad.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log("you win ");
                SceneManager.LoadScene("TBAG");
            }
            else if (position == exitpos && gotkey == false)
            {
                n.quad.GetComponent<Renderer>().material.color = Color.blue;
                Debug.Log("must find the key before exiting ");
            }   
        }
        if (position.x > 4 || position.x < 0 || position.y > 4 || position.y < 0)
        {
            SceneManager.LoadScene("TBAG");
        }
    }
}

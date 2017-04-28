using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGrid : MonoBehaviour
{


    public GameObject prefab;
    [SerializeField]
    private List<GameObject> cubes;
    
    
    // Use this for initialization
    void Start()
    {
         
         
    } 
    [ContextMenu("Create")]
    void ShowGrid()
    {

        cubes = new List<GameObject>();
        var cube;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                cube = Instantiate(prefab,this.transform) as GameObject;
                cube.transform.position = new Vector3(i, 0, j);
                cubes.Add(cube);
            }
        } 
    
    }
    [ContextMenu("Destroy")]
    void DstroyGrid()
    {
        foreach (GameObject item in cubes)
        {
            DestroyImmediate(item);
        }
        cubes.Clear();
    }
     
    // Update is called once per frame
    void Update()
    {

    }
}

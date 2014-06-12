using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour 
{

    public Vector3 size;

    public GameObject tilePrefab;

    Transform thisTransform;

    public GameObject[,] grid;

	// Use this for initialization
	void Start () 
    {
        thisTransform = transform;

        CreateGrid();
        
	

	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void CreateGrid()
    {
        grid = new GameObject[(int)size.x, (int)size.y];

        for (int x = 0; x < size.x; x += 2)
        {
            for (int y = 0; y < size.y; y += 2)
            {
                GameObject newTile = (GameObject)GameObject.Instantiate(tilePrefab, new Vector3( x , y, 0.0f ), Quaternion.identity);
                grid[x , y ] = newTile;
                newTile.transform.parent = thisTransform;
                newTile.transform.name = x.ToString() + y.ToString();


                
                
            }
        }
    }
}

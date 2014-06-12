using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JigzawGameManager : MonoBehaviour {


    
    float originalWidth = 640;
    float originalHeight = 480;

    public Texture jigsawTexture;


    Vector3 scale;

    GameObject newTile;
    Transform thisTransform;

    
    public int columns = 3;
    public int rows = 2;

    public GameObject jigsawPiece;
    GameObject[,] puzzle = new GameObject[4,4];


    

    // Use this for initialization
    void Start()
    {
       

        //CreateGrid();
        CreateGridWithPieces();



    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Who I'm" + newTile);
    }

    void CreateGridWithPieces()
    {
        
        for (int x = 0; x < columns; x++)
        {
            for (int z = 0; z < rows; z++)
            {

                // Todo lo que he probado...
                // puzzle[x, z] = (GameObject)Instantiate(jigsawPiece, new Vector3(-0.85f + x, 0.0f, -0.85f + z), Quaternion.Euler(0, 0, 0)) as GameObject;
                newTile = (GameObject)GameObject.Instantiate(jigsawPiece, new Vector3(-1f + x, 0.0f, -1f + z), Quaternion.identity);
                puzzle[x, z] = newTile;
                //newTile.renderer.material.mainTexture = jigsawTexture;
                newTile.transform.parent = thisTransform;

                
                //newTile.transform.name = x.ToString() + z.ToString();
                //int textureSize  = 10;
                //puzzle[x, z].gameObject.renderer.material.mainTexture.width = textureSize;

                //for (int i = 0; i < puzzle.Length; i++)
                //{
                   // puzzle[x, z].renderer.material.mainTexture = jigsawTexture;
                //}

            }
        }

        

        puzzle = new GameObject[columns, rows];
        

    }


    void OnGUI()
    {
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;

        Matrix4x4 svMatrix = GUI.matrix;

        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);

        GUI.color = Color.black;
        GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Jigzaw Game</size>");

        if (GUI.Button(new Rect(100, 100, 100, 100), "Shufle"))
        {
            //Here it will spread the pieces alongside the table
            //puzzle.transform.position = new Vector3(0, 0, 0);
           // puzzle[rows, columns].gameObject.transform.position = new Vector3(0, 0, 0);
            Debug.Log("Shufle");
        }




        GUI.matrix = svMatrix;



    }

    void CreateGrid()
    {
       /*grid = new GameObject[(int)size.x, (int)size.z];

        for (int x = 0; x < size.x; x ++)
        {
            for (int z = 0; z < size.z; z ++)
            {
                GameObject newTile = (GameObject)GameObject.Instantiate(tilePrefab, new Vector3(x , 0, z), Quaternion.identity);
                //GameObject puzzle = (GameObject)GameObject.Instantiate(jigsawPiece.Clone, new
                //grid[x, z] = newTile;
                //newTile.transform.parent = thisTransform;
                //newTile.transform.name = x.ToString() + z.ToString();

                newTile.renderer.material.mainTexture = jigsawTexture;
            }

            
        }*/
    }
    



    
}

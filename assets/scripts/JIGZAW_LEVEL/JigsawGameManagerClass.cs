using UnityEngine;
using System.Collections;

public class JigsawGameManagerClass : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    public Texture jigsawTexture;

    public bool shuffle = false;

    public GameObject jigsawPiece1;
    public GameObject jigsawPiece2;
    public GameObject jigsawPiece3;
    public GameObject jigsawPiece4;

    Vector3 jigsawStartPosition = new Vector3(5f, 10f, 0f);
    JigsawDragPlane jigsawDragPlaneClass;

    Vector3 scale;

    Vector3 startPoint;
    float startTime;
    float duration = 1.0f;

    Vector3 targetPositionPiece1 = new Vector3(-20, 15, 0);

    float steps = 100.0f;
    float t = 20.0f;




    public void Start()
    {
        

        startPoint = transform.position;
        startTime = Time.time;

        /*jigsawPiece1 = (GameObject)GameObject.Instantiate( jigsawPiece1, jigsawStartPosition, Quaternion.identity);
        jigsawPiece2 = (GameObject)GameObject.Instantiate(jigsawPiece2, new Vector3(23, 10, 0), Quaternion.identity);
        jigsawPiece3 = (GameObject)GameObject.Instantiate(jigsawPiece3, new Vector3(5, -2.5f, 0), Quaternion.identity);
        jigsawPiece4 = (GameObject)GameObject.Instantiate(jigsawPiece4, new Vector3(23, -2.5f, 0), Quaternion.identity);*/


        jigsawPiece1 = (GameObject)GameObject.Instantiate(jigsawPiece1, targetPositionPiece1, Quaternion.identity);
        jigsawPiece2 = (GameObject)GameObject.Instantiate(jigsawPiece2, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 11, 0), Quaternion.identity);
        jigsawPiece3 = (GameObject)GameObject.Instantiate(jigsawPiece3, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 23, 0), Quaternion.identity);
        jigsawPiece4 = (GameObject)GameObject.Instantiate(jigsawPiece4, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 33, 0), Quaternion.identity);


        jigsawPiece1.transform.name = "piece1";
        jigsawPiece2.transform.name = "piece2";
        jigsawPiece3.transform.name = "piece3";
        jigsawPiece4.transform.name = "piece4";


   
    }

    void Update()
    {
        WinState();
    }


    void WinState()
    {
        /*if (jigSawDragPlaneClass != null)
        {
            jigSawDragPlaneClass = (JigsawDragPlane)GameObject.Find("piece1").GetComponent<JigsawDragPlane>();

        }*/

        try
        {
            jigsawDragPlaneClass = (JigsawDragPlane)GameObject.Find("piece1").GetComponent<JigsawDragPlane>();
        }

        catch
        {
            print("my little error");
        }

        //Debug.Log("Count to Win" + jigSawDragPlaneClass.countToWin);

        if (jigsawDragPlaneClass.countToWin == 4)
        {
            GUI.Label(new Rect(10, 200, 200, 50), "'<size = 20>You Win!!!'");
            Debug.Log("You winn"); 
        }

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
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Jigzaw Game</size>");

        if (GUI.Button(new Rect(320, 400, 70, 50), "Shuffle"))
        {
            //Here it will spread the pieces alongside the table
            //puzzle.transform.position = new Vector3(0, 0, 0);
            // puzzle[rows, columns].gameObject.transform.position = new Vector3(0, 0, 0);
            //jigsawPiece1.gameObject(new Vector3(100f, 0.0f, 100f), Quaternion.identity);

            //jigsawPiece1.gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPositionPiece1, steps);
            jigsawPiece1.gameObject.transform.position = Vector3.Lerp(transform.position, targetPositionPiece1, Mathf.SmoothStep(0,10, 0.5f));
            //jigsawPiece1.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, 0);

            jigsawPiece2.gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 11, 0), Mathf.SmoothStep(0, 10, 0.5f));
            //jigsawPiece2.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, 0f);

            jigsawPiece3.gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 23, 0), Mathf.SmoothStep(0, 10, 0.5f));
            //jigsawPiece3.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, 0f);

            jigsawPiece4.gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(targetPositionPiece1.x, targetPositionPiece1.y - 33, 0), Mathf.SmoothStep(0, 10, 0.5f));
            //jigsawPiece4.gameObject.transform.localScale += new Vector3(-0.2f, -0.2f, 0f);


            //jigsawPiece4.gameObject.transform.position = Vector3.Lerp(transform.position, targetPositionPiece1, (Time.time - startTime) / duration);



            jigsawDragPlaneClass.JigsawWinTriggerClass1.hasCollideWith1 = false;
            jigsawDragPlaneClass.JigsawWinTriggerClass2.hasCollideWith2 = false;
            jigsawDragPlaneClass.JigsawWinTriggerClass3.hasCollideWith3 = false;
            jigsawDragPlaneClass.JigsawWinTriggerClass4.hasCollideWith4 = false;

            Debug.Log("Shuffle");
            
        }

        GUI.matrix = svMatrix;
    }




}



 

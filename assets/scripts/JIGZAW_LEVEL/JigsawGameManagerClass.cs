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

    public AudioClip wellDone;
    public GUIText youWinText;

    Vector3 jigsawStartPosition = new Vector3(5f, 10f, 0f);
    JigsawDragPlane jigsawDragPlaneClass1, jigsawDragPlaneClass2, jigsawDragPlaneClass3, jigsawDragPlaneClass4;

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

        try
        {
            jigsawDragPlaneClass1 = (JigsawDragPlane)GameObject.Find("piece1").GetComponent<JigsawDragPlane>();
            jigsawDragPlaneClass2 = (JigsawDragPlane)GameObject.Find("piece2").GetComponent<JigsawDragPlane>();
            jigsawDragPlaneClass3 = (JigsawDragPlane)GameObject.Find("piece3").GetComponent<JigsawDragPlane>();
            jigsawDragPlaneClass4 = (JigsawDragPlane)GameObject.Find("piece4").GetComponent<JigsawDragPlane>();
        }

        catch
        {
            print("my little error");
        }

        //Debug.Log("Count to Win" + jigsawDragPlaneClass1.countToWin);

        //Since each piece of the puzzle has its own countToWin value we have to check for any of them to equal 4 based on which is placed last
        if (jigsawDragPlaneClass1.countToWin >= 4 || jigsawDragPlaneClass2.countToWin >= 4 || jigsawDragPlaneClass3.countToWin >= 4 || jigsawDragPlaneClass4.countToWin >= 4)
        {

            //StartCoroutine(Fade.use.Alpha(youWinText.material, 1, 0, 1f));
            youWinText.text = "Well Done";
            //StartCoroutine(Fade.use.Alpha(youWinText.material, 0, 1, 0.4f));

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


            //Reset all values and put pieces back to original positions for shuffle
            youWinText.text = "";

            jigsawDragPlaneClass1.JigsawWinTriggerClass1.hasCollideWith1 = false;
            jigsawDragPlaneClass1.countToWin = 0;
            jigsawDragPlaneClass2.JigsawWinTriggerClass2.hasCollideWith2 = false;
            jigsawDragPlaneClass2.countToWin = 0;
            jigsawDragPlaneClass3.JigsawWinTriggerClass3.hasCollideWith3 = false;
            jigsawDragPlaneClass3.countToWin = 0;
            jigsawDragPlaneClass4.JigsawWinTriggerClass4.hasCollideWith4 = false;
            jigsawDragPlaneClass4.countToWin = 0;

            Debug.Log("Shuffle");
            
        }

        GUI.matrix = svMatrix;
    }




}



 

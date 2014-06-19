using UnityEngine;
using System.Collections;

public class ShapesGameManager : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale;

	public Texture jigsawTexture;
	
	public GameObject shape1;
	public GameObject shape2;
	public GameObject shape3;

    public AudioClip wellDone;

    public GUIText youWinText;

	Vector3 shapeStartPosition = new Vector3(5f, 10f, 0f);
    ShapeDragPlane shapeDragPlaneClass1, shapeDragPlaneClass2, shapeDragPlaneClass3;
    ShapeWinTrigger shapeWinTriggerClass;
	
	Vector3 startPoint;
	float startTime;
	float duration = 1.0f;
	
	Vector3 targetPosition = new Vector3(-5, 0, 0);

    int win = 0;
	
	float steps = 100.0f;
	float t = 20.0f;


    void OnGUI()
    {
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;

        Matrix4x4 svMatrix = GUI.matrix;

        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);

        GUI.color = Color.white;
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Shapes Game</size>");




        GUI.matrix = svMatrix;
    }

    public void Start()
    {

        startPoint = transform.position;
        startTime = Time.time;

        shape1 = (GameObject)GameObject.Instantiate(shape1, new Vector3(targetPosition.x, targetPosition.y, 0), Quaternion.identity);
        shape2 = (GameObject)GameObject.Instantiate(shape2, new Vector3(targetPosition.x, targetPosition.y - 3.5f, 0), Quaternion.identity);
        shape3 = (GameObject)GameObject.Instantiate(shape3, new Vector3(targetPosition.x, targetPosition.y + 3.5f, 0), Quaternion.identity);

        shape1.transform.name = "piece1";
        shape2.transform.name = "piece2";
        shape3.transform.name = "piece3";

    }

    void Update()
    {
        WinState();

    }

    void WinState()
    {

        try
        {
            shapeDragPlaneClass1 = (ShapeDragPlane)GameObject.Find("piece1").GetComponent<ShapeDragPlane>();
            shapeDragPlaneClass2 = (ShapeDragPlane)GameObject.Find("piece2").GetComponent<ShapeDragPlane>();
            shapeDragPlaneClass3 = (ShapeDragPlane)GameObject.Find("piece3").GetComponent<ShapeDragPlane>();
        }

        catch
        {
            print("my little error");
        }

        //Debug.Log("Count to Win" + shapeDragPlaneClass.countToWin);
        

        if ((shapeDragPlaneClass1.countToWin >= 3 || shapeDragPlaneClass2.countToWin >= 3 || shapeDragPlaneClass3.countToWin >= 3) && win == 0)
        {
            win = 1;
            Invoke("GameFinished", 1.0f);
            Debug.Log("You winn");
        }
        

    }

    void GameFinished()
    {
        AudioSource.PlayClipAtPoint(wellDone, Camera.main.transform.position);

        StartCoroutine(Fade.use.Alpha(youWinText.material, 1, 0, 1f));
        youWinText.text = "Well Done";
        //StartCoroutine(Fade.use.Alpha(youWinText.material, 0, 1, 0.4f));
    }


}

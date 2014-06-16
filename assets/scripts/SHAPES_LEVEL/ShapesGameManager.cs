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

	Vector3 shapeStartPosition = new Vector3(5f, 10f, 0f);
	ShapeDragPlane shapeDragPlaneClass;
	
	Vector3 startPoint;
	float startTime;
	float duration = 1.0f;
	
	Vector3 targetPosition = new Vector3(-5, 0, 0);


	
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
		
		/*jigsawPiece1 = (GameObject)GameObject.Instantiate( jigsawPiece1, jigsawStartPosition, Quaternion.identity);
        jigsawPiece2 = (GameObject)GameObject.Instantiate(jigsawPiece2, new Vector3(23, 10, 0), Quaternion.identity);
        jigsawPiece3 = (GameObject)GameObject.Instantiate(jigsawPiece3, new Vector3(5, -2.5f, 0), Quaternion.identity);
        jigsawPiece4 = (GameObject)GameObject.Instantiate(jigsawPiece4, new Vector3(23, -2.5f, 0), Quaternion.identity);*/


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
		/*if (jigSawDragPlaneClass != null)
        {
            jigSawDragPlaneClass = (JigsawDragPlane)GameObject.Find("piece1").GetComponent<JigsawDragPlane>();

        }*/
		
		try
		{
			shapeDragPlaneClass = (ShapeDragPlane)GameObject.Find("piece1").GetComponent<ShapeDragPlane>();
		}
		
		catch
		{
			print("my little error");
		}
		
		//Debug.Log("Count to Win" + shapeDragPlaneClass.countToWin);
		
		if (shapeDragPlaneClass.countToWin == 4)
		{

			GUI.Label(new Rect(10, 200, 200, 50), "'<size = 100>You Win!!!'");
			Debug.Log("You winn"); 
		}
		
	}


}

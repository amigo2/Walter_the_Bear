using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {



    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 2048;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 1536;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    // Scale variable
    Vector3 scale;


    public GameObject backgroundImage;

    public Texture gameButton;
    public Texture storyButton;

	// Use this for initialization
	void Start () {


        //Vector2 myPos = ReadjustGUIPosition(new Vector2(100, 50, 50, 50));
        //backgroundImage.gameObject.transform.position = ReadjustGUIPosition(0, 0, 1024, 768);
        //backgroundImage.gameObject.transform.localScale = ReadjustGUISize(5.5f, 4 , 2048,1536 );
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {

        //Initialize values acording to screen size.

        scale.y = Screen.height / originalHeight;// calculate vert scale

        scale.x = scale.y; // this will keep your ratio base on Vertical scale

        scale.z = 1;

        float scaleX = Screen.width / originalWidth; // store this for translate


        //Open matrix calculation.

        //Save Matrix, what this does is saving the values of the GUI Matrix(translation, scale, rotation) 
        Matrix4x4 svMatrix = GUI.matrix;

        //Recalculate the matrix..
        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);


        if (GUI.Button(new Rect(225 - 50, 60, 100, 30), "COUNTING"))
        {
            Application.LoadLevel("COUNTING_LEVEL");
        }


        /*if (GUI.Button(new Rect(ReadjustGUIPosition(512, 128, originalWidth, originalHeight).x,
                    ReadjustGUIPosition(300, 80, originalWidth, originalHeight).y,
                    ReadjustGUISize(215, 128, originalWidth, originalHeight).x,
                    ReadjustGUISize(215, 128, originalWidth, originalHeight).y), gameButton))
        {

        }*/

        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;
        
    }

    public Vector2 ReadjustGUIPosition(float originalPosX, float originalPosY, float originalWidth, float originalHeight)
    {
        Vector2 newPos = new Vector2(originalPosX * Screen.width / originalWidth, originalPosY * Screen.height / originalHeight);
        return newPos;
    }

    public Vector2 ReadjustGUISize(float originalSizeX, float originalSizeY, float originalWidth, float originalHeight)
    {
        Vector2 newPos = new Vector2(originalSizeX * Screen.width / originalWidth, originalSizeY * Screen.height / originalHeight);

        return newPos;
    }
}

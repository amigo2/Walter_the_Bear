using UnityEngine;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {

    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 2048;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 1536;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    public Texture2D gamesButton;
    public Texture2D gamesButtonClicked;
    public Texture2D taleButton;
    public Texture2D taleButtonClicked;

    //public Texture2D BackgroundTexture;
    public GameObject backGroundObject;

    public float autofadeTime = 0.5f;



    // Scale variable
    private Vector3 scale;

    void Start()
    {
        /*backGroundObject = (GameObject)GameObject.Instantiate(backGroundObject, new Vector3(ReadjustGUIPosition(0, 0, originalWidth, originalHeight).x,
                                                                                            ReadjustGUIPosition(0, 0, originalWidth, originalHeight).y, 0), Quaternion.identity);

        float z = 1;
        Vector3 backGroundScaleFactor = backGroundObject.gameObject.transform.localScale;
        backGroundScaleFactor.x = ReadjustGUISize(4, 4, originalWidth, originalHeight).x;
        backGroundScaleFactor.y = ReadjustGUISize(4, 4, originalWidth, originalHeight).y;
        backGroundScaleFactor.z = z;

        backGroundObject.gameObject.transform.localScale = backGroundScaleFactor;*/

        /*GUI.DrawTexture(new Rect(ReadjustGUIPosition(20, 12, originalWidth, originalHeight).x, ReadjustGUIPosition(20, 12, originalWidth, originalHeight).y,
                   ReadjustGUISize(70, 70, originalWidth, originalHeight).x, ReadjustGUISize(70, 70, originalWidth, originalHeight).y), heartHealth, ScaleMode.ScaleToFit, true, 0.0F);*/
        


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


    void OnGUI()
    {

        //Initialize values acording to screen size.
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;


        //Save Matrix, what this does is saving the values of the GUI Matrix(translation, scale, rotation) 
        //Open matrix calculation.
        Matrix4x4 svMatrix = GUI.matrix;

        //Recalculate the matrix..
        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);
        GUI.backgroundColor = Color.clear;

        //GUI.DrawTexture(new Rect(0, 0, 1024, 768), BackgroundTexture);


        //Button clickable. You dont need anymore neither define the position( This needs to be properly tested).
        if (GUI.Button(new Rect(1100, 700, taleButton.width, taleButton.height), taleButton))
        {
            taleButton = taleButtonClicked;
            //Application.LoadLevel("TALE");
            AutoFade.LoadLevel("TALE", autofadeTime, autofadeTime, Color.black);
        }
        if (GUI.Button(new Rect(1100, 900, gamesButton.width, gamesButton.height), gamesButton))
        {
            gamesButton = gamesButtonClicked;
            //Application.LoadLevel("GAMES_MENU");
            AutoFade.LoadLevel("GAMES_MENU", autofadeTime, autofadeTime, Color.black);
            
        }

        

        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;

    }

    void OnMouseDown()
    {
        
    }
}

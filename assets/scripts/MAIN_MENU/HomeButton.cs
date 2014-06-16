using UnityEngine;
using System.Collections;

public class HomeButton : MonoBehaviour {


    public Texture2D backButtonTexture;
    public Texture2D backButtonTextureClicked;

    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 2048;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 1536;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    // Scale variable
    Vector3 scale;

    public float autofadeTime = 0.5f;

    float screenWidthValue;
    float screenHeightValue;

    float leftMiddleAnchor;
    float leftTopAnchor;


    void Update()
    {
        //originalWidth = Screen.width;
        //originalHeight = Screen.height;
        //Debug.Log("Screen Width = " + screenWidthValue);
        //Debug.Log("Screen Height = " + screenHeightValue);
    }


    void OnGUI()
    {
        //leftTopAnchor = Screen.height / 10;


        //screenWidthValue = Screen.height;
        //screenHeightValue = Screen.width;


        //Initialize values acording to screen size.
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;


        //Save Matrix, what this does is saving the values of the GUI Matrix(translation, scale, rotation) 
        //Open matrix calculation.
        Matrix4x4 svMatrix = GUI.matrix;
        
        //Recalculate the matrix..
        //GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);
        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 , 0, 0), Quaternion.identity, scale);

        GUI.backgroundColor = Color.clear;

        //Button clickable. You dont need anymore neither define the position( This needs to be properly tested).
        if (GUI.Button(new Rect( 2080 - backButtonTexture.width, 1545 - backButtonTexture.height, backButtonTexture.width, backButtonTexture.height), backButtonTexture))
        {
            backButtonTexture = backButtonTextureClicked;
            //Application.LoadLevel("MAIN_MENU");
            if (Application.loadedLevelName.Equals("GAMES_MENU"))
                AutoFade.LoadLevel("MAIN_MENU", autofadeTime, autofadeTime, Color.black);
            else
                AutoFade.LoadLevel("GAMES_MENU", autofadeTime, autofadeTime, Color.black);
        }


        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;
       
    }

    


}

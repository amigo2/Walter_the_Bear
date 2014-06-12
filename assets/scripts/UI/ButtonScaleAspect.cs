using UnityEngine;
using System.Collections;

public class ButtonScaleAspect : MonoBehaviour {




    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 640;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 480;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    // Scale variable
    Vector3 scale;




    void OnGUI()
    {

        //Initialize values acording to screen size.
        
        scale.y = Screen.height / originalHeight;

        scale.x = scale.y;

        scale.z = 1;

        float scaleX = Screen.width / originalWidth; // store this for translate

        //Save Matrix, what this does is saving the values of the GUI Matrix(translation, scale, rotation) 
        //Open matrix calculation.
        Matrix4x4 svMatrix = GUI.matrix;

        //Recalculate the matrix..
        //GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);

        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);

        //Add al buttons to be recaltulated in whatever the size and maybe position
        //GUI.Button(new Rect (100, 100, 100 ,100),"Button");

        if (GUI.Button(new Rect(100, 100, 100, 100), "HOME"))
        {
            Application.LoadLevel("GAMES_MENU");
        }


        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;

    }
}

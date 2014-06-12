using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 2048;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 1536;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    // Scale variable
    Vector3 scale;



    void Awake()
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

        


        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;

    }


}

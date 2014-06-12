using UnityEngine;
using System.Collections;

public class PianoGameManager : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale;


    void OnGUI()
    {
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;

        Matrix4x4 svMatrix = GUI.matrix;

        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);

        GUI.color = Color.black;
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Piano Game</size>");




        GUI.matrix = svMatrix;



    }
}

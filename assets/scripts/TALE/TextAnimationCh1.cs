using UnityEngine;
using System.Collections;

public class TextAnimationCh1 : MonoBehaviour {

	//Original size, preferred size we are going to use to adapt size of buttons.
	float originalWidth = 640;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
	float originalHeight = 480;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.
	
	// Scale variable
	Vector3 scale;

	//int fontSize = 12;
	//Font font;


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

		//,"\n"
		//GUI.skin.label.font = GUI.skin.button.font = GUI.skin.box.font = font;
		//GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;


		GUI.color = Color.red;

		GUI.Label (new Rect (10, 380, 700, 180), "“<size=20>Hi, my name is Chuka and I’m, 5.\n This is my imaginary friend Walter the Bear. \n" +
		           "We always play together and " +
		           "have We are unaffected so much fun</size>”");



		//Close and return ne Matrix value.
		GUI.matrix = svMatrix;
	}
}

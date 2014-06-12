using UnityEngine;
using System.Collections;

public class GamesMenuButtons : MonoBehaviour {


    //Original size, preferred size we are going to use to adapt size of buttons.
    float originalWidth = 2048;// Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 2048.
    float originalHeight = 1536;//Don't know yet but problably if we are going to use textured ones, this might be the iPad size, 1536.

    public float autofadeTime = 0.5f;

    public Texture2D countingButtonTexture;
    public Texture2D countingButtonTextureClicked;
    public Texture2D alphalettterButtonTexture;
    public Texture2D alphalettterButtonTextureClicked;
    public Texture2D shapesButtonTexure;
    public Texture2D shapesButtonTexureClicked;
    public Texture2D spellButtonTexture;
    public Texture2D spellButtonTextureClicked;
    public Texture2D hiddenButtonTexture;
    public Texture2D hiddenButtonTextureClicked;
    public Texture2D jigsawButtonTexture;
    public Texture2D jigsawButtonTextureClicked;
    public Texture2D pianoButtonTexture;
    public Texture2D pianoButtonTextureClicked;

    public GameObject backgroundGameObject;



    // Scale variable
    Vector3 scale;


    void Start()
    {


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

        GUI.backgroundColor = Color.clear;
        
        if (GUI.Button(new Rect( 100, 200 , countingButtonTexture.width, countingButtonTexture.height), countingButtonTexture))
        {
            
            //Application.LoadLevel("COUNTING_LEVEL");
            AutoFade.LoadLevel("COUNTING_LEVEL", autofadeTime, autofadeTime, Color.black);
            countingButtonTexture = countingButtonTextureClicked;
        }

        if (GUI.Button(new Rect( 800, 200, alphalettterButtonTexture.width, alphalettterButtonTexture.height), alphalettterButtonTexture))
        {
            
            //Application.LoadLevel("ALPHALETTER_LEVEL");
            AutoFade.LoadLevel("ALPHALETTER_LEVEL", autofadeTime, autofadeTime, Color.black);
            alphalettterButtonTexture = alphalettterButtonTextureClicked;
        }

        if (GUI.Button(new Rect( 1500, 200, shapesButtonTexure.width, shapesButtonTexure.height), shapesButtonTexure))
        {
            
            //Application.LoadLevel("SHAPES_LEVEL");
            AutoFade.LoadLevel("SHAPES_LEVEL", autofadeTime, autofadeTime, Color.black);
            shapesButtonTexure = shapesButtonTexureClicked;
        }
        if (GUI.Button(new Rect( 100, spellButtonTexture.height + 300, spellButtonTexture.width, spellButtonTexture.height), spellButtonTexture))
        {
            
            //Application.LoadLevel("SPELL_LEVEL");
            AutoFade.LoadLevel("SPELL_LEVEL", 1, autofadeTime, Color.black);
            spellButtonTexture = spellButtonTextureClicked;
        }
        if (GUI.Button(new Rect( 800, hiddenButtonTexture.height + 300, hiddenButtonTexture.width, hiddenButtonTexture.height), hiddenButtonTexture))
        {
            
            //Application.LoadLevel("HIDDEN_LEVEL");
            AutoFade.LoadLevel("HIDDEN_LEVEL", autofadeTime, autofadeTime, Color.black);
            hiddenButtonTexture = hiddenButtonTextureClicked;
        }
        if (GUI.Button(new Rect( 1500, jigsawButtonTexture.height + 300, jigsawButtonTexture.width, jigsawButtonTexture.height), jigsawButtonTexture))
        {
            
            //Application.LoadLevel("JIGZAW_LEVEL");
            AutoFade.LoadLevel("JIGZAW_LEVEL", autofadeTime, autofadeTime, Color.black);
            jigsawButtonTexture = jigsawButtonTextureClicked;

        }

        if (GUI.Button(new Rect( 100, jigsawButtonTexture.height + 700, pianoButtonTexture.width, pianoButtonTexture.height), pianoButtonTexture))
        {
            
            //Application.LoadLevel("PIANO_LEVEL");
            AutoFade.LoadLevel("PIANO_LEVEL", autofadeTime, autofadeTime, Color.black);
            pianoButtonTexture = pianoButtonTextureClicked;
        }


        GUI.matrix = svMatrix;


    }
}

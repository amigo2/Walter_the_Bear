using UnityEngine;
using System.Collections;

public class FollowNumbersClick : MonoBehaviour {

    public Texture2D normalTexture;
    public Texture2D clickedTexture;


    // Use this for initialization
    void Start()
    {

        guiTexture.texture = normalTexture;

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*void OnMouseUp()
    {
        guiTexture.texture = clickedTexture;
    }*/

    void OnMouseDown()
    {
        guiTexture.texture = clickedTexture;
        Application.LoadLevel("FOLLOW_NUMBERS");
    }
}

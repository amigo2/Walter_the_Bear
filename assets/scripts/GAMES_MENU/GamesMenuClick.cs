using UnityEngine;
using System.Collections;

public class GamesMenuClick : MonoBehaviour {

    //public GameObject dragAndDropButton;

    public GUITexture dragAndDropButton;
    public GUITexture followNumbers;

	// Use this for initialization
	void Start () {

        dragAndDropButton = GameObject.Find("DragButton").guiTexture;
        followNumbers = GameObject.Find("FollowButton").guiTexture;



	
	}
	
	// Update is called once per frame
	void Update () {

        
       
        
	
	}

    void OnGUI()
    {
        if (dragAndDropButton.HitTest(Input.mousePosition))
        {
            Debug.Log("Drag");
            Application.LoadLevel("DRAG_AND_DROP");
        }

        if (followNumbers.HitTest(Input.mousePosition))
        {
            Debug.Log("Follow");
            Application.LoadLevel("FOLLOW_NUMBERS");
        }
        

    }


}

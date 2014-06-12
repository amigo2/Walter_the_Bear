using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Manager : MonoBehaviour {

    public int numberOfTiles;
    public List<bool> tilesPickedUp;
    public List<int> tilesDrawing;
    public List<Animator> pnAnimators;

	// Use this for initialization
	void Start () {
        Check_Scene();

        SetTilesNumber();
        ResetBoolPickedUp();
        FillListOfTiles();
        GetPNAnimators();
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    void Check_Scene()
    {
        switch (Application.loadedLevelName)
        {
            case "LEVEL_1":
                numberOfTiles = 24;
                break;
        }
    }

    void SetTilesNumber()
    {
        bool tilePick = false;
        for (int i = 1; i <= numberOfTiles; i++)
        {
            tilesPickedUp.Add(tilePick);

        }
    }

    void ResetBoolPickedUp()
    {
        for (int i = 1; i <= numberOfTiles; i++)
        {
            //tilesPickedUp[i] = false;
            
        }
    }

    void FillListOfTiles()
    {
        for (int i = 1; i <= numberOfTiles; i++)
        {
            tilesDrawing.Add(i);
            
        }
        for (int i = 1; i < numberOfTiles; i++)
        {
            
            tilesDrawing[i] = i;
        }
    }

    void GetPNAnimators()
    {
        Animator pnAnimator;
        for (int i = 1; i <= numberOfTiles; i++)
        {
            //Debug.Log(GameObject.Find("PN" + i.ToString()));
            pnAnimator = GameObject.Find("PN" + i.ToString()).GetComponent<Animator>();
            pnAnimators.Add(pnAnimator);
        }
    }

}

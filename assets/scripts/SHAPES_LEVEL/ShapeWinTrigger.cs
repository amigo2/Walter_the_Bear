using UnityEngine;
using System.Collections;

public class ShapeWinTrigger : MonoBehaviour {

	GameObject piece;
	public bool hasCollideWith1 = false;
	public bool hasCollideWith2 = false;
	public bool hasCollideWith3 = false;
	public GUIText winText;

	Transform myTransform;
	string name;
	
	int collision = 4;

    
	
	// Use this for initialization
	void Start () {
		
		myTransform = transform;
		name = myTransform.name;
		
		//Debug.Log(myTransform.name);
		//myTransform.name = 
		//anyPiece = GameObject.Find("piece1");
		
		Debug.Log("exist");
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
	
	void OnTriggerEnter( Collider piece)
	{
		//hasColide = true;
		//Debug.Log("Has piece1 collide true");
		
		if (name == "ColliderPiece1")
		{

			if (piece.name == "piece1")
			{
				hasCollideWith1 = true;
				Debug.Log("ColliderPiiiiiiiiiiiiece1");
			}

			
			//hasCollideWith1 = false;
		}
		
		if (name == "ColliderPiece2")
		{
			if (piece.name == "piece2")
			{
				hasCollideWith2 = true;
				Debug.Log("ColliderPiiiiiiiiiiiiece2");
			}
			//hasCollideWith2 = false;
		}
		if (name == "ColliderPiece3")
		{
			if (piece.name == "piece3")
			{
				hasCollideWith3 = true;
				Debug.Log("ColliderPiiiiiiiiiiiiece3");
			}
			//hasCollideWith3 = false;
		}

		
	}
	
}	
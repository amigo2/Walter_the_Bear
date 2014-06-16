using UnityEngine;
using System.Collections;


//[RequireComponent(typeof(BoxCollider))]
public class ShapeDragPlane : MonoBehaviour {
	
	GameObject piece1;
	GameObject piece2;
	GameObject piece3;
	
	GameObject colliderPiece1;
	GameObject colliderPiece2;
	GameObject colliderPiece3;
	
	ShapeWinTrigger ShapeWinTriggerClass1, ShapeWinTriggerClass2, ShapeWinTriggerClass3;
	
	private Vector3 screenPoint;
	private Vector3 offset;
	
	Vector3 sidePositionPiece1 = new Vector3(-5.0f, 0.0f, 0.0f);
	Vector3 sidePositionPiece2 = new Vector3(-5.0f, -3.5f, 0.0f);
	Vector3 sidePositionPiece3 = new Vector3(-5.0f, 3.5f, 0.0f);
	
	
	Vector3 winPositionPiece1 = new Vector3(4.5f, 3.5f, 0.0f);
	Vector3 winPositionPiece2 = new Vector3(4.5f, 0.0f, 0.0f);
	Vector3 winPositionPiece3 = new Vector3(4.5f, -4.5f, 0.0f);
	
	bool isRelease = false;
	
	private Transform myTransform;
	
	//Snap to grid
	float snapToGridX = 1.0f;
	float snapToGridY = 1.0f;
	float snapToGridZ = 1.0f;
	
	public int countToWin = 0;
	
	void Start()
	{
		
		ShapeWinTriggerClass1 = (ShapeWinTrigger)GameObject.Find("ColliderPiece1").GetComponent<ShapeWinTrigger>();
		ShapeWinTriggerClass2 = (ShapeWinTrigger)GameObject.Find("ColliderPiece2").GetComponent<ShapeWinTrigger>();
		ShapeWinTriggerClass3 = (ShapeWinTrigger)GameObject.Find("ColliderPiece3").GetComponent<ShapeWinTrigger>();

		//Jigsaw Pieces
		piece1 = GameObject.Find("piece1");
		piece2 = GameObject.Find("piece2");
		piece3 = GameObject.Find("piece3");
		
		//Collider parts
		colliderPiece1 = GameObject.Find("ColliderPiece1");
		colliderPiece2 = GameObject.Find("ColliderPiece2");
		colliderPiece3 = GameObject.Find("ColliderPiece3");
		
		
		myTransform = transform;
		
	}
	
	
	void OnMouseDown()
	{
		isRelease = false;
		
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		
	}
	
	void OnMouseDrag()
	{
		isRelease = false;
		
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
		
	}
	
	
	void OnMouseUp()
	{
		isRelease = true;
		
		
		if (ShapeWinTriggerClass1.hasCollideWith1 == true && isRelease == true)
		{
			countToWin++;
			/*Vector3 newPositionPiece1 = piece1.gameObject.transform.position;
			newPositionPiece1.x = Mathf.Round(winPositionPiece1.x / winPositionPiece1.x) * winPositionPiece1.x;
			newPositionPiece1.y = Mathf.Round(winPositionPiece1.y / snapToGridY) * snapToGridY;
			newPositionPiece1.z = Mathf.Round(newPositionPiece1.z / snapToGridZ) * snapToGridZ;*/
			piece1.gameObject.transform.position = winPositionPiece1;
			
			
		}
		else
		{
			/*Vector3 newPositionPiece1 = piece1.gameObject.transform.position;
			newPositionPiece1.x = Mathf.Round(sidePositionPiece1.x / sidePositionPiece1.x) * sidePositionPiece1.x;
			newPositionPiece1.y = Mathf.Round(sidePositionPiece1.y / snapToGridY) * snapToGridY;
			newPositionPiece1.z = Mathf.Round(newPositionPiece1.z / snapToGridZ) * snapToGridZ;*/

			piece1.gameObject.transform.position = sidePositionPiece1;
			
			
		}
		
		if (ShapeWinTriggerClass2.hasCollideWith2 == true && isRelease == true )
		{
			countToWin++;
			/*Vector3 newPositionPiece2 = piece2.gameObject.transform.position;
			newPositionPiece2.x = Mathf.Round(winPositionPiece2.x / winPositionPiece2.x) * winPositionPiece2.x;
			newPositionPiece2.y = Mathf.Round(winPositionPiece2.y / snapToGridY) * snapToGridY;
			newPositionPiece2.z = Mathf.Round(winPositionPiece2.z / snapToGridZ) * snapToGridZ;*/

			piece2.gameObject.transform.position = winPositionPiece2;
			
			
		}
		else
		{
			/*Vector3 newPositionPiece2 = piece2.gameObject.transform.position;
			newPositionPiece2.x = Mathf.Round(sidePositionPiece2.x / sidePositionPiece2.x) * sidePositionPiece2.x;
			newPositionPiece2.y = Mathf.Round(sidePositionPiece2.y / snapToGridY) * snapToGridY;
			newPositionPiece2.z = Mathf.Round(sidePositionPiece2.z / snapToGridZ) * snapToGridZ;*/

			piece2.gameObject.transform.position = sidePositionPiece2;
			
		}
		
		if (ShapeWinTriggerClass3.hasCollideWith3 == true && isRelease == true)
		{
			countToWin++;
			/*Vector3 newPositionPiece3 = piece3.gameObject.transform.position;
			newPositionPiece3.x = Mathf.Round(winPositionPiece3.x / winPositionPiece3.x) * winPositionPiece3.x;
			newPositionPiece3.y = Mathf.Round(winPositionPiece3.y / snapToGridY) * snapToGridY;
			newPositionPiece3.z = Mathf.Round(winPositionPiece3.z / snapToGridZ) * snapToGridZ;*/

			piece3.gameObject.transform.position = winPositionPiece3;
			
		}
		else
		{
			/*Vector3 newPositionPiece3 = piece3.gameObject.transform.position;
			newPositionPiece3.x = Mathf.Round(sidePositionPiece3.x / sidePositionPiece3.x) * sidePositionPiece3.x;
			newPositionPiece3.y = Mathf.Round(sidePositionPiece3.y / snapToGridY) * snapToGridY;
			newPositionPiece3.z = Mathf.Round(sidePositionPiece3.z / snapToGridZ) * snapToGridZ;*/

			piece3.gameObject.transform.position = sidePositionPiece3;
			
		}
		
		
	}
	
	
}

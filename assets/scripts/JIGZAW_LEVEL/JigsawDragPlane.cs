using UnityEngine;
using System.Collections;


//[RequireComponent(typeof(BoxCollider))]
public class JigsawDragPlane : MonoBehaviour {

    GameObject piece1;
    GameObject piece2;
    GameObject piece3;
    GameObject piece4;

    GameObject colliderPiece1;
    GameObject colliderPiece2;
    GameObject colliderPiece3;
    GameObject colliderPiece4;

    public JigsawWinTrigger JigsawWinTriggerClass1, JigsawWinTriggerClass2, JigsawWinTriggerClass3, JigsawWinTriggerClass4;


	private Vector3 screenPoint;
    private Vector3 offset;

    Vector3 sidePositionPiece1 = new Vector3(-20f, 15f, 0.0f);
    Vector3 sidePositionPiece2 = new Vector3(-20f, 4f, 0.0f);
    Vector3 sidePositionPiece3 = new Vector3(-20f, -8f, 0.0f);
    Vector3 sidePositionPiece4 = new Vector3(-20f, -18f, 0.0f);


    Vector3 winPositionPiece1 = new Vector3(5.0f  , 10.0f, 0.0f);
    Vector3 winPositionPiece2 = new Vector3(23.0f , 10.0f, 0.0f);
    Vector3 winPositionPiece3 = new Vector3(5.0f  , -2.5f, 0.0f);
    Vector3 winPositionPiece4 = new Vector3(23.0f , -2.5f, 0.0f);

    bool isRelease = false;

    private Transform myTransform;

    //Snap to grid
    float snapToGridX = 1.0f;
    float snapToGridY = 1.0f;
    float snapToGridZ = 1.0f;

    public int countToWin = 0;

    void Start()
    {

        JigsawWinTriggerClass1 = (JigsawWinTrigger)GameObject.Find("ColliderPiece1").GetComponent<JigsawWinTrigger>();
        JigsawWinTriggerClass2 = (JigsawWinTrigger)GameObject.Find("ColliderPiece2").GetComponent<JigsawWinTrigger>();
        JigsawWinTriggerClass3 = (JigsawWinTrigger)GameObject.Find("ColliderPiece3").GetComponent<JigsawWinTrigger>();
        JigsawWinTriggerClass4 = (JigsawWinTrigger)GameObject.Find("ColliderPiece4").GetComponent<JigsawWinTrigger>();
        
        //Jigsaw Pieces
        piece1 = GameObject.Find("piece1");
        piece2 = GameObject.Find("piece2");
        piece3 = GameObject.Find("piece3");
        piece4 = GameObject.Find("piece4");

        //Collider parts
        colliderPiece1 = GameObject.Find("ColliderPiece1");
        colliderPiece2 = GameObject.Find("ColliderPiece2");
        colliderPiece3 = GameObject.Find("ColliderPiece3");
        colliderPiece4 = GameObject.Find("ColliderPiece4");


        myTransform = transform;

    }

    void Update()
    {
        //Debug.Log("Count to win " + countToWin);
        
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

        
            if (JigsawWinTriggerClass1.hasCollideWith1 == true && isRelease == true)
            {
                countToWin++;
                Vector3 newPositionPiece1 = piece1.gameObject.transform.position;
                newPositionPiece1.x = Mathf.Round(winPositionPiece1.x / winPositionPiece1.x) * winPositionPiece1.x;
                newPositionPiece1.y = Mathf.Round(winPositionPiece1.y / snapToGridY) * snapToGridY;
                newPositionPiece1.z = Mathf.Round(newPositionPiece1.z / snapToGridZ) * snapToGridZ;
                piece1.gameObject.transform.position = newPositionPiece1;
                

            }
            else
            {
                Vector3 newPositionPiece1 = piece1.gameObject.transform.position;
                newPositionPiece1.x = Mathf.Round(sidePositionPiece1.x / sidePositionPiece1.x) * sidePositionPiece1.x;
                newPositionPiece1.y = Mathf.Round(sidePositionPiece1.y / snapToGridY) * snapToGridY;
                newPositionPiece1.z = Mathf.Round(newPositionPiece1.z / snapToGridZ) * snapToGridZ;
                piece1.gameObject.transform.position = newPositionPiece1;


            }

            if (JigsawWinTriggerClass2.hasCollideWith2 == true && isRelease == true )
            {
                countToWin++;
                Vector3 newPositionPiece2 = piece2.gameObject.transform.position;
                newPositionPiece2.x = Mathf.Round(winPositionPiece2.x / winPositionPiece2.x) * winPositionPiece2.x;
                newPositionPiece2.y = Mathf.Round(winPositionPiece2.y / snapToGridY) * snapToGridY;
                newPositionPiece2.z = Mathf.Round(winPositionPiece2.z / snapToGridZ) * snapToGridZ;
                piece2.gameObject.transform.position = newPositionPiece2;


            }
            else
            {
                Vector3 newPositionPiece2 = piece2.gameObject.transform.position;
                newPositionPiece2.x = Mathf.Round(sidePositionPiece2.x / sidePositionPiece2.x) * sidePositionPiece2.x;
                newPositionPiece2.y = Mathf.Round(sidePositionPiece2.y / snapToGridY) * snapToGridY;
                newPositionPiece2.z = Mathf.Round(sidePositionPiece2.z / snapToGridZ) * snapToGridZ;
                piece2.gameObject.transform.position = newPositionPiece2;
                
            }

            if (JigsawWinTriggerClass3.hasCollideWith3 == true && isRelease == true)
            {
                countToWin++;
                Vector3 newPositionPiece3 = piece3.gameObject.transform.position;
                newPositionPiece3.x = Mathf.Round(winPositionPiece3.x / winPositionPiece3.x) * winPositionPiece3.x;
                newPositionPiece3.y = Mathf.Round(winPositionPiece3.y / snapToGridY) * snapToGridY;
                newPositionPiece3.z = Mathf.Round(winPositionPiece3.z / snapToGridZ) * snapToGridZ;
                piece3.gameObject.transform.position = newPositionPiece3;
                
            }
            else
            {
                Vector3 newPositionPiece3 = piece3.gameObject.transform.position;
                newPositionPiece3.x = Mathf.Round(sidePositionPiece3.x / sidePositionPiece3.x) * sidePositionPiece3.x;
                newPositionPiece3.y = Mathf.Round(sidePositionPiece3.y / snapToGridY) * snapToGridY;
                newPositionPiece3.z = Mathf.Round(sidePositionPiece3.z / snapToGridZ) * snapToGridZ;
                piece3.gameObject.transform.position = newPositionPiece3;

            }

            if (JigsawWinTriggerClass4.hasCollideWith4 == true && isRelease == true)
            {
                countToWin++;
                Vector3 newPositionPiece4 = piece4.gameObject.transform.position;
                newPositionPiece4.x = Mathf.Round(winPositionPiece4.x / winPositionPiece4.x) * winPositionPiece4.x;
                newPositionPiece4.y = Mathf.Round(winPositionPiece4.y / snapToGridY) * snapToGridY;
                newPositionPiece4.z = Mathf.Round(winPositionPiece4.z / snapToGridZ) * snapToGridZ;
                piece4.gameObject.transform.position = newPositionPiece4;
                
            }
            else
            {
                Vector3 newPositionPiece4 = piece4.gameObject.transform.position;
                newPositionPiece4.x = Mathf.Round(sidePositionPiece4.x / sidePositionPiece4.x) * sidePositionPiece4.x;
                newPositionPiece4.y = Mathf.Round(sidePositionPiece4.y / snapToGridY) * snapToGridY;
                newPositionPiece4.z = Mathf.Round(sidePositionPiece4.z / snapToGridZ) * snapToGridZ;
                piece4.gameObject.transform.position = newPositionPiece4;

            }
       
        
    }


}

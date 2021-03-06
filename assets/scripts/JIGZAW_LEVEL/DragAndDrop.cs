﻿using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
public class DragAndDrop : MonoBehaviour {

    public int normalCollisionCount = 1;
    public float moveLimit = .5f;
    public float collisionMoveFactor = .01f;
    public float addHeightWhenClicked = 0.0f;
    public bool freezeRotationOnDrag = true;
    public Camera cam;
    private Rigidbody myRigidBody;
    private Transform myTransform;
    private bool canMove = false;
    private float yPos;
    private bool gravitySettings;
    private bool freezeRotationSetting;
    private float sqrMoveLimit;
    private int collisionCount = 0;
    private Transform camTransform;


    //Snap to grid
    float snapToGridX = 1.0f;
    float snapToGridY = 1.0f;
    float snapToGridZ = 1.0f;



	// Use this for initialization
	void Start () 
    {
        myRigidBody = rigidbody;
        myTransform = transform;

        if (!cam)
        {
            cam = Camera.main;
        }
        if (!cam)
        {
            Debug.LogError("Can't find camera tagged MainCamera!");
            return;
        }
        camTransform = cam.transform;
        sqrMoveLimit = moveLimit * moveLimit; // Since we're using sqrMagnitude, which is faster than magnitude
	
	}


    void OnMouseDown()
    {
        canMove = true;
        myTransform.Translate(Vector3.up * addHeightWhenClicked);
        gravitySettings = myRigidBody.useGravity;
        freezeRotationSetting = myRigidBody.freezeRotation;
        myRigidBody.useGravity = false;
        myRigidBody.freezeRotation = freezeRotationOnDrag;
        yPos = myTransform.position.y;
    }

    void OnMouseUp()
    {
        canMove = false;
        myRigidBody.useGravity = gravitySettings;
        myRigidBody.freezeRotation = freezeRotationSetting;
        if (!myRigidBody.useGravity)
            {
                Vector3 pos = myTransform.position;
                pos.y = yPos - addHeightWhenClicked;
                myTransform.position = pos;

                /*Vector3 newPosition = myTransform.position;
                newPosition.x = Mathf.Round(newPosition.x / snapToGridX) * snapToGridX;
                newPosition.y = Mathf.Round(newPosition.y / snapToGridY) * snapToGridY;
                newPosition.z = Mathf.Round(newPosition.z / snapToGridZ) * snapToGridZ;
                myTransform.position = newPosition;*/
            }

        
    }

    void OnCollisionEnter()
    {
        collisionCount++;
    }

    void OnCollisionExit()
    {
        collisionCount--;
    }

    void FixedUpdate()
    {
        if (!canMove)
        {
            return;
        }

        myRigidBody.velocity = Vector3.zero;
        myRigidBody.angularVelocity = Vector3.zero;
        
        Vector3 pos = myTransform.position;
        pos.y = yPos;
        myTransform.position = pos;

        Vector3 mousePos = Input.mousePosition;
        Vector3 move = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camTransform.position.y - myTransform.position.y)) - myTransform.position;
        move.y = 0.0f;

        if (collisionCount > normalCollisionCount)
        {
            move = move.normalized * collisionMoveFactor;
        }

        else if (move.sqrMagnitude > sqrMoveLimit)
        {
            move = move.normalized * moveLimit;

        }

        myRigidBody.MovePosition(myRigidBody.position + move);

    }

}

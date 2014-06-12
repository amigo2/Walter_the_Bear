﻿using UnityEngine;
using System.Collections;

public class Movement_Script_Click : MonoBehaviour {

		private Transform myTransform;				// this transform
		private Vector3 destinationPosition;		// The destination Point
		private float destinationDistance;			// The distance between myTransform and destinationPosition
		
		public float moveSpeed;						// The Speed the character will move
		
		Animator CharAnimator;
		public static bool playerCannotMove = false;
		
		public bool notClickToMove;
		
		public bool BootsOn = false;
		
		public static bool StopMoving;
		
		void Start () {
			myTransform = transform;							// sets myTransform to this GameObject.transform
			destinationPosition = myTransform.position;		
			CharAnimator = transform.GetComponent<Animator>();
			
			
		}

			
		
		void Update () {
			//CharAnimator.SetFloat("Speed", 0.0f); //Idle Animation activated	
			
		
			// keep track of the distance between this gameObject and destinationPosition
			destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);
			
			if(destinationDistance <= 0.0f){		// To prevent shakin behavior when near destination (before 0.5f)
				moveSpeed = 0;
			}
			else if(destinationDistance > .5f){			// To Reset Speed to default
				moveSpeed = 3;
			}
			
			
			// Moves the Player if the Left Mouse Button was clicked
			
			
			if (Input.GetMouseButtonDown(0)&& GUIUtility.hotControl ==0) {
				//Control here that if the click is out of the grid don't move
				
				CharAnimator.SetFloat("Speed", 0.2f); 
				Plane playerPlane = new Plane(Vector3.up, myTransform.position);
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				float hitdist = 0.0f;
				
				if (playerPlane.Raycast(ray, out hitdist)) {
					Vector3 targetPoint = ray.GetPoint(hitdist);


				Quaternion targetRotation = Quaternion.LookRotation(- targetPoint + transform.position);
				myTransform.rotation = targetRotation;

					destinationPosition = ray.GetPoint(hitdist);
					
				
						}
					}
			
			
			
			// Moves the player if the mouse button is hold down
			if (Input.GetMouseButton(0)&& GUIUtility.hotControl ==0) {
				
				CharAnimator.SetFloat("Speed", 0.2f); //Idle Animation activated
				Plane playerPlane = new Plane(Vector3.up, myTransform.position);
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				float hitdist = 0.0f;
				
				if (playerPlane.Raycast(ray, out hitdist)) {
					Vector3 targetPoint = ray.GetPoint(hitdist);
					destinationPosition = ray.GetPoint(hitdist);
					Quaternion targetRotation = Quaternion.LookRotation(- targetPoint + transform.position);
					myTransform.rotation = targetRotation;
				}
				
			}

            myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, Time.deltaTime * moveSpeed);

            if (myTransform.position == destinationPosition)
            {
                CharAnimator.SetFloat("Speed", 0.0f); 
            }
		}
  }
		

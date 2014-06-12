using UnityEngine;
using System.Collections;

public class PianoKeyScript : MonoBehaviour {

    public float semitone_offset = 0;

   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetMouseButtonDown(0))
        {
            //PlayNote();
            //this.rigidbody.AddForce(new Vector3(0f, 0.2f, 0f));

        }
    
	
	}

    void OnMouseDown()
    {
        PlayNote();
    }

    void PlayNote()
    {
        audio.pitch = Mathf.Pow(2.0f, semitone_offset / 12.0f);
        audio.Play();
        animation.Play("press");
        //Debug.Log("Fuck");
        //this.rigidbody.AddForce(new Vector3(0f, 10f, 0f));

    }
}

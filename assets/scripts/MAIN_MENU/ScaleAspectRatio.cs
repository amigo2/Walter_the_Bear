using UnityEngine;
using System.Collections;

public class ScaleAspectRatio : MonoBehaviour {

    public Vector2 scaleOnRatio1 = new Vector2(0.1f, 0.1f);
    private Transform myTransform;
    private float withHeightRatio;

	// Use this for initialization
	void Start () 
    {
        myTransform = transform;
        SetScale();
	
	}


    void SetScale()
    {
        withHeightRatio = (float)Screen.width / Screen.height;

        myTransform.localScale = new Vector3(scaleOnRatio1.x, withHeightRatio * scaleOnRatio1.y, 1);

    }


}

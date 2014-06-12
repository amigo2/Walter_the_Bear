using UnityEngine;
using System.Collections;

public class HiddenGameManager : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale;
	Vector3 point1 = new Vector3(-7,0,0);
	Vector3 point2 = new Vector3(1,0,0);
	Vector3 point3 = new Vector3(8,0,0);
	Vector3 trans1 = new Vector3 (3, 3, 3);
	Vector3 trans2 = new Vector3 (1.8f, 1.8f, 1.8f);
	Vector3 trans3 = new Vector3 (2.3f, 2.3f, 2.3f);

	public GUIText message;

    public GameObject item;

    int index = 0;

    void Start()
    {
		InstantiateItem();
    }

	void Update()
	{

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		
		if (Input.GetMouseButtonDown (0)) 
		{
			Physics.Raycast(ray, out hit, Mathf.Infinity);
			
			if (hit.collider != null) {
				Debug.Log (hit.collider.gameObject.name);
				if (hit.collider.gameObject.name == "item0")
				{
					StartCoroutine(Fade.use.Alpha(message.material, 0, 1, 0.2f));
					message.guiText.text = "You Win!";
				}
				else
				{
					StartCoroutine(Fade.use.Alpha(message.material, 0, 1, 0.2f));
					message.guiText.text = "Incorrect, try again";
                    StartCoroutine(Fade.use.Alpha(hit.collider.renderer.material, 1, 0, 0.2f));
                    Invoke("DestroyText", 1.0f);
				}
			}
		}
	}

    void DestroyText()
    {
        StartCoroutine(Fade.use.Alpha(message.material, 1, 0, 0.2f));
    }

    void InstantiateItem()
    {
        for (int i = 0; i < 3; i++)
        {
			int range = Random.Range (-5,5);
			Vector3 point  = new Vector3(0,0,0);
			Vector3 trans = new Vector3(0,0,0);
			if (i == 0)
			{
				point = point1;
				trans = trans1;
			}
			if (i == 1)
			{
				point = point2;
				trans = trans2;
			}
			if (i == 2)
			{
				point = point3;
				trans = trans3;
			}
            item = (GameObject)GameObject.Instantiate( item, point, Quaternion.identity);
			item.transform.localScale = trans;
			item.name = "item" + i;
        }

    }


    void OnGUI()
    {
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;

        Matrix4x4 svMatrix = GUI.matrix;

        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2 * originalWidth, 0, 0), Quaternion.identity, scale);

        GUI.color = Color.blue;
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Hidden Game</size>");




        GUI.matrix = svMatrix;



    }
}

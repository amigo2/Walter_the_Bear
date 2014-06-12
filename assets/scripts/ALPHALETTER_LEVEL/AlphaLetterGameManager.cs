using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//This Level one letter after another in alphabetic order..

public class AlphaLetterGameManager : MonoBehaviour 
{
    public List<GameObject> alphaletters = new List<GameObject>();
    List<GameObject> alreadySpawn = new List<GameObject>();

	public int test;

    public AudioClip a;
    public AudioClip b;
    public AudioClip c;

    Transform thisTransform;

    GameObject spawned;
    int counterLetters;

    int index = 0;
    int counter = 0;
    
    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale, letterScale;

    void Start()
    {
        InstantiateLetters();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && spawned.gameObject != null)
        //if (Input.GetMouseButtonDown(0))
        {
            //Physics.Raycast(ray, out hit, Mathf.Infinity);
            //if (hit.collider != null)
            //{
                LetterSounds();
                Destroy(spawned.gameObject);
                Invoke("InstantiateLetters", 1);
            //}
            
        }
        
    }

    void InstantiateLetters()
    {
        if (index < alphaletters.Count)
        {
            spawned = (GameObject)GameObject.Instantiate(alphaletters[index], Vector3.zero, Quaternion.identity);
            letterScale.x = 2;
            letterScale.y = 2;
            spawned.gameObject.transform.localScale = letterScale;
            spawned.name = "Letter" + index;
            index++;
            
           
        }
        else
        {
            //Well done!!
        }
    }

    void LetterSounds()
    {
        if (index == 1)
        {
            AudioSource.PlayClipAtPoint(a, Camera.main.transform.position);
            
        }
        if (index == 2)
        {
            AudioSource.PlayClipAtPoint(b, Camera.main.transform.position);

        }
        if (index == 3)
        {
            AudioSource.PlayClipAtPoint(c, Camera.main.transform.position);

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

        GUI.color = Color.white;
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20> Alphaletter Game</size>");


        /*if (GUI.Button(new Rect(50, 300, 100, 100), "NEXT"))
        {
           
        }
        if (GUI.Button(new Rect (100,100,100,100),"Restart"))
        {
            //counterLetters = 0;
        }*/

        GUI.matrix = svMatrix;
    }
}

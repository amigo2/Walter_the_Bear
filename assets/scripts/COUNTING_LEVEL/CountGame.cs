using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CountGame : MonoBehaviour {

    //Size elements

    List<GameObject> itemsSpawned = new List<GameObject>();
	public List<GameObject> numbersList = new List<GameObject>();
	List<GameObject> particleList = new List<GameObject>();

    float originalWidth = 640;
    float originalWeight = 480;
    float topStart = 0, botStart = 0;

    public GameObject particles;

    GameObject item;
    GameObject[] myCube;

    Vector3 scale;

    bool gamesTerminates = false;
    bool itemIsAlive = true;

    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    public AudioClip five;
    public AudioClip six;
    public AudioClip seven;
    public AudioClip eight;
    public AudioClip nine;
    public AudioClip ten;
    public AudioClip clickSound;
    public AudioClip wellDone;

    public Texture2D itemTexture;
    public GameObject clickItem;
    public GUIText youWinText;

	GameObject spawned;
	GameObject spawned10;
	int index = 1;
	int numCounter = 0;
	Vector3 numLocation = new Vector3 (0, -5.0f, -1);

    int counter = 1;
    int totalCounter = 10;
    int rest = 0;


    // Add the scalabel thingy
    void Start()
    {
        InstantiateObject();
        
        //CaulculateObjects();
        //counter++;
 
    }

    void Update()
    {

        //Debug.Log("Counter" + counter);
        //Debug.Log("Rest" + rest);

        //rest = counter;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Input.GetMouseButtonDown(0))
        {
            
            Physics.Raycast(ray, out hit, Mathf.Infinity);
            if (hit.collider != null)
            {
                
                
                rest--;

                InstantiateParticles(hit);
                particleList.Add(particles);
                
                Destroy(hit.collider.gameObject);
                
                //Debug.Log("rest = " + rest);

                WellDone();

                if (rest == 0 && counter <= 10)
                {
                    
                    Invoke("InstantiateObject", 1.0f);
                    WinTime();

                }
                else if (rest == 0 && counter <= 11)
                {
                    float myTime = 2f;
                    AudioSource.PlayClipAtPoint(ten, Camera.main.transform.position);
                    counter++;
					InstantiateNumber(0);
                    Invoke("DestroyText", 0.5f);

                    Invoke("GameFinished", myTime);

                }

            }

        }

    }

	void InstantiateNumber(int index)
	{
		float offset = 0.75f;
		
		if (index == 0)
		{
			Vector3 num10location0 = new Vector3(numLocation.x+offset, numLocation.y, numLocation.z);
			Vector3 num10location1 = new Vector3(numLocation.x-offset, numLocation.y, numLocation.z);
			spawned10 = (GameObject)GameObject.Instantiate(numbersList[0], num10location0, Quaternion.identity);
			spawned = (GameObject)GameObject.Instantiate(numbersList[1], num10location1, Quaternion.identity);
		}
		else
		{
			spawned = (GameObject)GameObject.Instantiate(numbersList[index], numLocation, Quaternion.identity);
			spawned.name = "Number" + index;
		}

		
	}

    void InstantiateParticles(RaycastHit hit)
    {
        particles = (GameObject)GameObject.Instantiate(particles, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -2), 
            Quaternion.Euler(new Vector3(180, 0, 0)));
    }

    void InstantiateObject()
    {
        float spacer = 0;
		float topSpacer = 0;
        float botSpacer = 0;

        for (int i = 0; i < counter; i++)
        {
            if (i < 5 && counter < 6)
            {
                item = (GameObject)GameObject.Instantiate(clickItem,
                    new Vector3(topStart + spacer, clickItem.GetComponent<BoxCollider>().bounds.size.y, 0), Quaternion.identity);
                spacer+=3;
            }
            
            else if (i < 5)
            {
                item = (GameObject)GameObject.Instantiate(clickItem,
                    new Vector3(topStart + topSpacer, clickItem.GetComponent<BoxCollider>().bounds.size.y + 2.5f, 0), Quaternion.identity);
                topSpacer += 3;
            }
            else
            {
                item = (GameObject)GameObject.Instantiate(clickItem,
                    new Vector3(botStart + botSpacer, clickItem.GetComponent<BoxCollider>().bounds.size.y - 2.5f, 0), Quaternion.identity);
                botSpacer += 3;
            }

            item.name = "Item" + counter;
            rest++;


        }

        //Debug.Log("I'm Here");

        if (counter < 5)
            topStart -= 1.5f;
        else if (counter > 5)
            botStart -= 1.5f;

        counter++;
        DestroyParticles();


        //Debug.Log("Added rest to total = " + rest);
        //Debug.Log("Added counter to total = " + counter);

    }

    void DestroyParticles()
    {
        for (int i = 0; i < particleList.Count-1; i++)
        {
            Destroy(particleList[i]);
        }
        
    }

    void DestroyText()
    {
		if (counter<12)
		{
			StartCoroutine(Fade.use.Alpha(spawned.renderer.material, 1, 0, 0.2f));
			Debug.Log ("counter " + counter);
		}
		else
		{
            StartCoroutine(Fade.use.Alpha(spawned.renderer.material, 1, 0, 0.2f));
			StartCoroutine(Fade.use.Alpha(spawned10.renderer.material, 1, 0, 0.2f));
            StartCoroutine(Fade.use.Alpha(youWinText.material, 1, 0, 0.4f));
		}

        Destroy(spawned.gameObject, 1);
    }

    void WinTime()
    {
  
        if (counter == 2)
        {
            AudioSource.PlayClipAtPoint(one, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 3)
        {
            AudioSource.PlayClipAtPoint(two, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 4)
        {
            AudioSource.PlayClipAtPoint(three, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 5)
        {
            AudioSource.PlayClipAtPoint(four, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 6)
        {
            AudioSource.PlayClipAtPoint(five, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 7)
        {
            AudioSource.PlayClipAtPoint(six, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 8)
        {
            AudioSource.PlayClipAtPoint(seven, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 9)
        {
            AudioSource.PlayClipAtPoint(eight, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }
        else if (counter == 10)
        {
            AudioSource.PlayClipAtPoint(nine, Camera.main.transform.position);
			InstantiateNumber(index);
			index++;

            Invoke("DestroyText", 0.5f);
        }

    }

    void GameFinished()
    {
        AudioSource.PlayClipAtPoint( wellDone, Camera.main.transform.position);

        StartCoroutine (Fade.use.Alpha(youWinText.material, 0, 1, 0.4f));
        youWinText.text = "Well Done";
        StartCoroutine (Fade.use.Alpha(youWinText.material, 1, 0, 1.0f));

        for (int i = 0; i < particleList.Count; i++)
        {
            Destroy(particleList[i]);
        }
 
    }



    void WellDone()
    {
        //AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);

        
    }

    void OnGUI()
    {

        /*if (GUI.Button(new Rect(100, 100, 60, 60), itemTexture))
        {
            myCube = GameObject.FindGameObjectsWithTag("myCube");
            if (counter <= 10)
            //if (myCube != null)
            //if (GameObject.FindGameObjectsWithTag ("myCube") == null)
            {
                InstantiateObject(counter);
                //CaulculateObjects();
            }
            //myRange = Random.Range(-5.0f, 5.0f);

            //instatiatedItem = (GameObject)GameObject.Instantiate(clickItem, new Vector3(myRange, 0, myRange), Quaternion.identity);
            //instatiatedItem.name = "myCube" + counter;
            //Debug.Log("I'm Here" + clickItem);

            //counter++;

        }*/
    }

    /*void CaulculateObjects()
    {
        Vector3 staringPoint = new Vector3( 0, 20,0 );
        float radius = 50.0F;
        RaycastHit[] hits;
        hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, Mathf.Infinity);
        //hits = Physics.SphereCastAll(Camera.main.transform.position, radius, Camera.main.transform.forward, Mathf.Infinity);
        
        int i = 0;

        Debug.Log("what the heel");

        if (hits.Length > 0)
        {
            Debug.Log("I'm looking after " + hits[i]);
        }

        while (i < hits.Length)
        {
            RaycastHit hitted = hits[i];

            Debug.Log("Hitted by raycast " + hits[i]);
        }

    }*/


}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// Shuffle the letters and instanciate it.
// Shuffle the animals and instanciate it, in the prefered position.
// if click in the right animal win.

public class QuizzGame : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale;

    public GameObject[] letters;
    List<GameObject> alreadySapwendLetters = new List<GameObject>();

    public GameObject[] animals;
    List<GameObject> spawnedAnimals = new List<GameObject>();
    GameObject animales;

    //Transform[poin] spawnLocations;

    Vector3 point1 = new Vector3(-5, -4, 0);
    Vector3 point2 = new Vector3(0, -4, 0);
    Vector3 point3 = new Vector3(5, -4, 0);


    float[] points;

    Vector3 xPos = new Vector3(-5, -5, 0);

    GameObject letter;

    GameObject animal;

    public GUIText youWinText;
    public GUIText youLoseText;
    public GameObject particles;
    List<GameObject> particleList = new List<GameObject>();

    int indexAnimals = 1;
    int counterLetters = 0;

    void Start()
    {
        
        SuffleWithoutRepeating(letters);
        InstantiateAnimals(animals);
        //Print();

    }
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Input.GetMouseButtonDown(0))
        {

            Physics.Raycast(ray, out hit, Mathf.Infinity);
            if (hit.collider != null)
            {
                //Debug.Log(hit.collider.gameObject.name);
                string firstLetterAnimal = hit.collider.gameObject.name.Substring(0, 1);
                string firstLetter = letter.gameObject.name.Substring(0, 1);

                InstantiateParticles(hit);
                particleList.Add(particles);

                Destroy(hit.collider.gameObject);

                if (firstLetterAnimal == firstLetter)
                {
                    Debug.Log("You winnnn !!!");
                    youWinText.text = "You Win!";
                    youWinText.pixelOffset = new Vector2(0, 200);
                    Invoke("ResetWinText", 1.0f);

                }
                else
                {
                    Debug.Log("Noooooooooooooooooooo");
                    //StartCoroutine(Fade.use.Alpha(youLoseText.material, 1, 0, 0.4f));
                    youLoseText.text = "Wrong";
                    Invoke("ResetLoseText", 1.0f);

                }

            }

            
        }
    }

    // Instatite only 3.
    void InstantiateAnimals(GameObject[] obj)
    {
        for (int i = 0; i < obj.Length ; i++)
        {
            GameObject temp = obj[i];
            //int random = Random.Range(0, obj.Length);
            int range = Mathf.Clamp(0, 0, obj.Length);
            obj[i] = obj[range];
            obj[range] = temp;

            //obj[i].name = "animals" + i;

            //spawnedAnimals.Add(obj[i]);  
        }

        for (int x = 0; x < 3; x++)
        {

            Vector3 positionToSpawn = new Vector3(0.0f, 0.0f, 0.0f);
            /*switch (x)
            {
                case 0:
                    positionToSpawn = point1;
                    break;
                case 1:
                    positionToSpawn = point2;
                    break;
                case 2:
                    positionToSpawn = point3;
                    break;
            }*/

            if (x == 0)
            {
                positionToSpawn = point1;
            }
            if (x == 1)
            {
                positionToSpawn = point2;
            }
            if (x == 2)
            {
                positionToSpawn = point3;
            }


            animales = (GameObject)GameObject.Instantiate(obj[x], positionToSpawn, Quaternion.identity);
            //animales.gameObject.name = "animals" + x;
        }


    
        
    }

    void InstantiateParticles(RaycastHit hit)
    {
        particles = (GameObject)GameObject.Instantiate(particles, new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y, -2),
            Quaternion.Euler(new Vector3(180, 0, 0)));
    }

    void DestroyParticles()
    {
        for (int i = 0; i < particleList.Count - 1; i++)
        {
            Destroy(particleList[i]);
        }

    }

    void ResetWinText()
    {
        youWinText.text = "";
    }

    void ResetLoseText()
    {
        youLoseText.text = "";
    }

    // Shuffle letters.
    void SuffleWithoutRepeating( GameObject[] obj)
    {
        if (counterLetters == 3)
        {
            return;
        }

    ReRandom:

        int objIndex = Random.Range(0, obj.Length);

        for (int i = 0; i < alreadySapwendLetters.Count; i++)
        {
            if (alreadySapwendLetters[i])
            {
                if ( alreadySapwendLetters[i] == obj[objIndex])
                {
                    goto ReRandom;
                }
            }

        }

        alreadySapwendLetters.Add(obj[objIndex]);
        counterLetters++;

        //Destroy(letter.gameObject);

        letter = (GameObject)GameObject.Instantiate(obj[objIndex], new Vector3(0,2,0), Quaternion.identity);

        
        //letter.name = "Letter" + objIndex;
        
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
        //GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Spell Game</size>");

        if (GUI.Button(new Rect(100, 100, 100, 100), "SHUFFLE"))
        {

            GameObject letterObject = GameObject.FindGameObjectWithTag("Letter");
            Destroy(letterObject.gameObject);


            GameObject[] animals = GameObject.FindGameObjectsWithTag("spellThingy");
            Debug.Log(animals);

            foreach (GameObject item in animals)
            {
                Destroy(item.gameObject);
            }

            SuffleWithoutRepeating(letters);
            InstantiateAnimals(animals);

            //Destroy(animals[].gameObject);
           

            //Destroy(letter.gameObject);

            /*for (int i = 0; i < 3; i++)
            {
                

                GameObject thingy = (GameObject)GameObject.Find("animals" + i);
                //Destroy(thingy.gameObject);

            }*/
            
        }




        GUI.matrix = svMatrix;



    }



}

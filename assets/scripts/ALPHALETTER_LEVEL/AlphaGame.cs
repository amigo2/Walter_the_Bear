using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AlphaGame : MonoBehaviour {

    public Texture2D[] alphaLetters;
    List<Texture> alreadySpawn = new List<Texture>();

    Texture spawned;
    int counterLetters;

    int counter = 0;


    void Start()
    {
        ShuffledWithoutRepeating(alphaLetters);
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ShuffledWithoutRepeating(alphaLetters);
        }



    }


    void OnGUI()
    {
        /*if (GUI.Button(new Rect(50, 300, 100, 100), "SHUFFLE"))
        {

            try
            {
                //Destroy(Texture.FindObjectOfType<Texture>("Object" + counter).gameObject);
            }
            catch
            {

            }


            counter++;


            ShuffledWithoutRepeating(alphaLetters);



        }*/
    }


    void ShuffledWithoutRepeating(Texture2D[] obj)
    {
        if (counterLetters == 5)
        {
            return;
        }

         reRandom:

        int objIndex = Random.Range(0, obj.Length);

         for (int i = 0; i < alreadySpawn.Count; i++)
         {
             if (alreadySpawn[i])
             {
                 if (alreadySpawn[i] == obj[objIndex])
                 {
                     goto reRandom;
                 }
             }

         }

         alreadySpawn.Add(obj[objIndex]);
         counterLetters++;

         renderer.material.mainTexture = obj[objIndex];

    }
}

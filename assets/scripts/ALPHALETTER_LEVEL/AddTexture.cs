using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddTexture : MonoBehaviour {

    float originalWidth = 640;
    float originalHeight = 480;

    Vector3 scale;

    public Texture[] texture;

    List<Texture> alreadySpawn = new List<Texture>();


    Texture spawned;
    int counter = 0;
    int counterLetters;

	// Use this for initialization
	void Start () {

        //renderer.material.mainTexture = texture[0];
        alreadySpawn.Clear();
        
        //ShuffleWithoutRepeating(texture);
        
	
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
        GUI.Label(new Rect(350 - 100, 20, 200, 50), "<size=20>Spell Game</size>");

        if (GUI.Button(new Rect(50, 300, 100, 100), "SHUFFLE"))
        {

            try
            {
                //Destroy(Texture.FindObjectOfType<Texture>("Object" + counter).gameObject);
            }
            catch
            {

            }
            counter++;
            ShuffleWithoutRepeating(texture);
        }

        GUI.matrix = svMatrix;

    }



    public void ShuffleWithoutRepeating(Texture[] obj)
    {

        if (counterLetters == 5)
        {
            return;
        }
       

           reRandom:

        int obj_index = Random.Range(0, obj.Length);

            

            for (int p = 0; p < alreadySpawn.Count; p++)
            {
                if (alreadySpawn[p])
                {
                    if (alreadySpawn[p] == obj[obj_index])
                    {
                        goto reRandom;
                    }
                }
                
                
            }
                alreadySpawn.Add(obj[obj_index]);
                counterLetters++;

        renderer.material.mainTexture = obj[obj_index];
    }



}

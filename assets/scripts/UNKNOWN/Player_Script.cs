using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {

    public static int playerTile;
    RaycastHit checkOutPlayerTile;
    Transform thisTransform;
    string tileNameTemp;
    Animator piggyAnimator;

    Game_Manager GMScript;

	// Use this for initialization
	void Start () {
        thisTransform = transform;
        piggyAnimator = thisTransform.GetComponent<Animator>();
        GMScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Game_Manager>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(thisTransform.position);
        Physics.Raycast(thisTransform.position + new Vector3(0.0f, 1.0f, 0.0f), new Vector3(0.0f, -0.1f, 0.0f), out checkOutPlayerTile);
        if (checkOutPlayerTile.collider != null)
        {
            
            tileNameTemp = checkOutPlayerTile.collider.transform.name;
            
            if (tileNameTemp.Length > 0)
            {
                if (tileNameTemp.Length > 9)
                {
                    tileNameTemp = tileNameTemp.Substring(8, 2);
                }
                else
                {
                    tileNameTemp = tileNameTemp.Substring(8, 1);
                }
                playerTile = int.Parse(tileNameTemp);
                Debug.Log(playerTile);
            }
        }

        if (playerTile > 0)
        {
            switch (playerTile)
            {
                case 1:
                    if (GMScript.tilesPickedUp[0] == false)
                    {
                        GMScript.pnAnimators[0].SetTrigger("StepOn");
                        GMScript.tilesPickedUp[0] = true;
                    }
                    break;
                case 2:
                    if (GMScript.tilesPickedUp[0] == true){
                        if (GMScript.tilesPickedUp[1] == false)
                        {
                            GMScript.pnAnimators[1].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[1] = true;
                        }
                    }
                    break;
                case 3:
                    if (GMScript.tilesPickedUp[1] == true)
                    {
                        if (GMScript.tilesPickedUp[2] == false)
                        {
                            GMScript.pnAnimators[2].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[2] = true;
                        }
                    }
                    break;
                case 4:
                    if (GMScript.tilesPickedUp[2] == true)
                    {
                        if (GMScript.tilesPickedUp[3] == false)
                        {
                            GMScript.pnAnimators[3].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[3] = true;
                        }
                    }
                    break;
                case 5:
                    if (GMScript.tilesPickedUp[3] == true)
                    {
                        if (GMScript.tilesPickedUp[4] == false)
                        {
                            GMScript.pnAnimators[4].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[4] = true;
                        }
                    }
                    break;
                case 6:
                    if (GMScript.tilesPickedUp[4] == true)
                    {
                        if (GMScript.tilesPickedUp[5] == false)
                        {
                            GMScript.pnAnimators[5].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[5] = true;
                        }
                    }
                    break;
                case 7:
                    if (GMScript.tilesPickedUp[5] == true)
                    {
                        if (GMScript.tilesPickedUp[6] == false)
                        {
                            GMScript.pnAnimators[6].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[6] = true;
                        }
                    }
                    break;
                case 8:
                    if (GMScript.tilesPickedUp[6] == true)
                    {
                        if (GMScript.tilesPickedUp[7] == false)
                        {
                            GMScript.pnAnimators[7].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[7] = true;
                        }
                    }
                    break;
                case 9:
                    if (GMScript.tilesPickedUp[7] == true)
                    {
                        if (GMScript.tilesPickedUp[8] == false)
                        {
                            GMScript.pnAnimators[8].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[8] = true;
                        }
                    }
                    break;
                case 10:
                    if (GMScript.tilesPickedUp[8] == true)
                    {
                        if (GMScript.tilesPickedUp[9] == false)
                        {
                            GMScript.pnAnimators[9].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[9] = true;
                        }
                    }
                    break;
                case 11:
                    if (GMScript.tilesPickedUp[9] == true)
                    {
                        if (GMScript.tilesPickedUp[10] == false)
                        {
                            GMScript.pnAnimators[10].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[10] = true;
                        }
                    }
                    break;
                case 12:
                    if (GMScript.tilesPickedUp[10] == true)
                    {
                        if (GMScript.tilesPickedUp[11] == false)
                        {
                            GMScript.pnAnimators[11].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[11] = true;
                        }
                    }
                    break;
                case 13:
                    if (GMScript.tilesPickedUp[11] == true)
                    {
                        if (GMScript.tilesPickedUp[12] == false)
                        {
                            GMScript.pnAnimators[12].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[12] = true;
                        }
                    }
                    break;
                case 14:
                    if (GMScript.tilesPickedUp[12] == true)
                    {
                        if (GMScript.tilesPickedUp[13] == false)
                        {
                            GMScript.pnAnimators[13].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[13] = true;
                        }
                    }
                    break;
                case 15:
                    if (GMScript.tilesPickedUp[13] == true)
                    {
                        if (GMScript.tilesPickedUp[14] == false)
                        {
                            GMScript.pnAnimators[14].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[14] = true;
                        }
                    }
                    break;
                case 16:
                    if (GMScript.tilesPickedUp[14] == true)
                    {
                        if (GMScript.tilesPickedUp[15] == false)
                        {
                            GMScript.pnAnimators[15].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[15] = true;
                        }
                    }
                    break;
                case 17:
                    if (GMScript.tilesPickedUp[15] == true)
                    {
                        if (GMScript.tilesPickedUp[16] == false)
                        {
                            GMScript.pnAnimators[16].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[16] = true;
                        }
                    }
                    break;
                case 18:
                    if (GMScript.tilesPickedUp[16] == true)
                    {
                        if (GMScript.tilesPickedUp[17] == false)
                        {
                            GMScript.pnAnimators[17].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[17] = true;
                        }
                    }
                    break;
                case 19:
                    if (GMScript.tilesPickedUp[17] == true)
                    {
                        if (GMScript.tilesPickedUp[18] == false)
                        {
                            GMScript.pnAnimators[18].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[18] = true;
                        }
                    }
                    break;
                case 20:
                    if (GMScript.tilesPickedUp[18] == true)
                    {
                        if (GMScript.tilesPickedUp[19] == false)
                        {
                            GMScript.pnAnimators[19].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[19] = true;
                        }
                    }
                    break;
                case 21:
                    if (GMScript.tilesPickedUp[19] == true)
                    {
                        if (GMScript.tilesPickedUp[20] == false)
                        {
                            GMScript.pnAnimators[20].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[20] = true;
                        }
                    }
                    break;
                case 22:
                    if (GMScript.tilesPickedUp[20] == true)
                    {
                        if (GMScript.tilesPickedUp[21] == false)
                        {
                            GMScript.pnAnimators[21].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[21] = true;
                        }
                    }
                    break;
                case 23:
                    if (GMScript.tilesPickedUp[21] == true)
                    {
                        if (GMScript.tilesPickedUp[22] == false)
                        {
                            GMScript.pnAnimators[22].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[22] = true;
                        }
                    }
                    break;
                case 24:
                    if (GMScript.tilesPickedUp[22] == true)
                    {
                        if (GMScript.tilesPickedUp[23] == false)
                        {
                            GMScript.pnAnimators[23].SetTrigger("StepOn");
                            GMScript.tilesPickedUp[23] = true;

                            piggyAnimator.SetTrigger("Dance1");
                        }
                    }
                    break;
            }
        }
	}
}

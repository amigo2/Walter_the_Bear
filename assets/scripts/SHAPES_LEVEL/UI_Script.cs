using UnityEngine;
using System.Collections;

public class UI_Script : MonoBehaviour {

		/*public Texture LifePixel; //Texture to draw life bar
		public Texture LifeFrame; //Frame to draw 
		public Texture TimerFrame; //Timer frame
		public Texture StaveFrame;
        public Texture ScoreTexture;
        public Texture FacebookTexture;
        public Texture FacebookClickedTexture;
        public Texture TweeterTexture;
        public Texture TweeterClickedTexture;
        public Texture RestartTexture;
        public Texture RestartTextureClicked;
        public Texture mainMenu;
        public Texture NextLevel;
          
            
		public GUIStyle TimerStyle; //Style of the Timer
		public GUIStyle CoinStyle; //Style of the Coin text
		public GUIStyle MoneyStyle; //Style of the Money text
		public GUIStyle LifeTextStyle;	//Style of the Life text

        public static bool ShowFBClicked;
        public static bool ShowTWClicked;
        public static bool ShowRestartCliked;

		//Textures of the notes
		public Texture blackNoteTexture_NPU;
		public Texture blackNoteTexture_PU;
		public Texture greenNoteTexture_NPU;
		public Texture greenNoteTexture_PU;
		public Texture yellowNoteTexture_NPU;
		public Texture yellowNoteTexture_PU;
		public Texture blueNoteTexture_NPU;
		public Texture blueNoteTexture_PU;
		public Texture whiteNoteTexture_NPU;
		public Texture whiteNoteTexture_PU;
		public Texture purpleNoteTexture_NPU;
		public Texture purpleNoteTexture_PU;
		public Texture redNoteTexture_NPU;
		public Texture redNoteTexture_PU;
		
		Combinations combScript; //Combinations script	
		
		//MUSIC NOTES ENGLISH
		//c --> DO --> Black
		//d --> RE --> Green
		//e --> MI --> Yellow
		//f --> FA --> blue
		//g --> SOL --> White
		//a --> LA --> Purple
		//b --> SI --> Red

		public Texture number_0;
		public Texture number_1;
		public Texture number_2;
		public Texture number_3;
		public Texture number_4;
		public Texture number_5;
		public Texture number_6;
		public Texture number_7;
		public Texture number_8;
		public Texture number_9;
	
	
		public Texture letter_A;
		public Texture letter_B;
		public Texture letter_C;
		public Texture letter_D;
		public Texture letter_E;
		public Texture letter_F;
		public Texture letter_G;
		public Texture letter_H;
		public Texture letter_I;
		public Texture letter_J;
		public Texture letter_K;
		public Texture letter_L;
		public Texture letter_M;
		public Texture letter_N;
		public Texture letter_O;
		public Texture letter_P;
		public Texture letter_Q;
		public Texture letter_R;
		public Texture letter_S;
		public Texture letter_T;
		public Texture letter_U;
		public Texture letter_V;
		public Texture letter_W;
		public Texture letter_X;
		public Texture letter_Y;
		public Texture letter_Z;
	
		
		public static bool showText = false;
		public static string textToShow;
		public static int ScreenWidthControl = 135;

		Vector2 top_corner_Left;
		Vector2 top_center;
		Vector2 top_corner_right;
		Vector2 bottom_corner_left;
		Vector2 bottom_center;
		Vector2 bottom_corner_right;
		Vector2 margin;
		Vector2 lifePoint;
	
		// Use this for initialization
		void Start () {
            GUI.enabled = true;
			combScript = (Combinations)GameObject.FindGameObjectWithTag ("Grid").GetComponent<Combinations> ();

			float acurate 			= 2.0f;
			top_corner_Left 		= new Vector2 (0.0f, 0.0f);
			top_center 				= new Vector2 (Screen.width / 2, 0.0f);
			top_corner_right 		= new Vector2 (Screen.width, 0f);
			bottom_corner_left 		= new Vector2 (0.0f, Screen.height);
			bottom_center 			= new Vector2 (Screen.width / 2, Screen.height);
			bottom_corner_left		= new Vector2 (Screen.width, Screen.height);
			margin					= new Vector2 (Screen.width / 80, Screen.height / 80);
			lifePoint 				= new Vector2 (Screen.width / 8 + acurate , Screen.height / 40);

            GL.Clear(true, true, Color.clear);
            
			}
		
		// Update is called once per frame
		void Update () {
			
		}

        void ClearScreen()
        {
            for (int x = 0; x <= Screen.width; x++)
            {
                for (int y = 0; y <= Screen.height; y++)
                {
                    
                }
            }
            
        }


        void OnGUI()
        {
            
            //GUI.Box (new Rect (18, 49, 501, 62), "");


            //Here we draw the UI Life

            // Life Frame
            GUI.DrawTexture(new Rect((int)top_corner_Left.x + (int)margin.x, (int)top_corner_Left.y + (int)margin.y, 337, 122), LifeFrame, ScaleMode.StretchToFill, true, 0.0F);

            //Life Pixel
            //GUI.DrawTexture(new Rect( (int)top_corner_Left.x + (int)lifePoint.x +2.0f, (int)top_corner_Left.y + (int)lifePoint.y, Player_Script.Player_Current_Life * 2, 40), LifePixel, ScaleMode.StretchToFill, true, 0.0F);
            GUI.DrawTexture(new Rect(150, 20, Player_Script.Player_Current_Life * 2, 40), LifePixel, ScaleMode.StretchToFill, true, 0.0F);
            //StaveFrame
            //GUI.DrawTexture(new Rect((int)top_corner_right.x - 670, (int)top_corner_right.y + (int)margin.y + 10, 512, 100), StaveFrame, ScaleMode.StretchToFill, true, 0.0F);

            //TimerFrame
            //GUI.DrawTexture(new Rect((int)top_corner_right.x - 150, (int)top_corner_right.y + (int)margin.y, 128, 128), TimerFrame, ScaleMode.StretchToFill, true, 0.0F);

            

            string text;

            // Timer text
            //text = "Combinations OK: " + Spawn_Script.combinationsCounter;
            //GUI.Label(new Rect(Screen.width / 2 - 480, 190, 200, 20), text, TimerStyle);

            // Coin text
            //text = "Coin Collected: " + Game_Manager.Coin_Counter;
            //GUI.Label(new Rect(Screen.width / 2 - 480, 220, 200, 20), text, CoinStyle);

            // Money text
            //text = "Money Collected: " + Game_Manager.Money_Counter;
            //GUI.Label(new Rect(Screen.width / 2 - 480, 250, 200, 20), text, MoneyStyle);

            text = "BEST COMBINATION: " + PlayerPrefs.GetInt("HighComb");
            //GUI.Label(new Rect(Screen.width / 2 - 480, 580, 200, 20), text, MoneyStyle);

            text = "BEST COIN: " + PlayerPrefs.GetInt("HighCoins");
            //GUI.Label(new Rect(Screen.width / 2 - 480, 610, 200, 20), text, MoneyStyle);

            text = "BEST MONEY: " + PlayerPrefs.GetInt("HighMoney");
            //GUI.Label(new Rect(Screen.width / 2 - 480, 640, 200, 20), text, MoneyStyle);

            /*if (GUI.Button(new Rect(Screen.width / 2 - 480, 670, 120, 20), "DELETE STATS"))
            {
                PlayerPrefs.DeleteAll();
            }*/

            /*switch (Game_Manager.Time_to_Finish)
            {
                case 10:
                    //GUI.DrawTexture(new Rect(Screen.width / 2 - 350, 700, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 9:
			GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_9, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 8:
			GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_8, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 7:
			GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_7, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 6:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_6, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 5:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_5, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 4:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_4, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 3:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_3, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 2:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_2, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                case 1:
			                GUI.DrawTexture(new Rect((int)top_corner_right.x - 100, (int)top_corner_right.y + (int)margin.y + 45, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                    break;
                /*case 0:
                    if(Game_Manager.Game_Started == true){
                    GUI.DrawTexture(new Rect(Screen.width / 2 + 450, 700, 32, 32), number_0, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;

            }*/

           /* switch (combScript.firstNoteComb)
            {
                case "C":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), blackNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), blackNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "D":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), greenNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), greenNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "E":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), yellowNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), yellowNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "F":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), blueNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), blueNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "G":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), whiteNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), whiteNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "A":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), purpleNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), purpleNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "B":
                    if (Objects_Hit_Player.firstPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), redNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 450, 20, 92, 106), redNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
            }

            switch (combScript.secondNoteComb)
            {
                case "C":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), blackNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), blackNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "D":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), greenNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), greenNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "E":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), yellowNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), yellowNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "F":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), blueNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), blueNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "G":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), whiteNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), whiteNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "A":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), purpleNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), purpleNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "B":
                    if (Objects_Hit_Player.secondPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), redNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 390, 20, 92, 106), redNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
            }

            switch (combScript.thirdNoteComb)
            {
                case "C":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), blackNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), blackNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "D":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), greenNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), greenNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "E":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), yellowNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), yellowNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "F":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), blueNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), blueNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "G":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), whiteNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), whiteNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "A":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), purpleNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), purpleNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "B":
                    if (Objects_Hit_Player.thirdPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), redNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 330, 20, 92, 106), redNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
            }

            switch (combScript.fourthNoteComb)
            {
                case "C":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), blackNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), blackNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "D":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), greenNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), greenNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "E":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), yellowNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), yellowNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "F":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), blueNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), blueNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "G":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {

                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), whiteNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), whiteNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "A":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), purpleNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), purpleNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
                case "B":
                    if (Objects_Hit_Player.fourthPickedUP == false)
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), redNoteTexture_NPU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    else
                    {
                        GUI.DrawTexture(new Rect((int)top_corner_right.x - 270, 20, 92, 106), redNoteTexture_PU, ScaleMode.StretchToFill, true, 0.0F);
                    }
                    break;
            }


            /*if (showText == true)
            {
                int textLenght = textToShow.Length;
                int ScreenControl = ScreenWidthControl;

                for (int i = 0; i < textLenght; i++)
                {

                    string letterToShow = textToShow.Substring(i, 1);
                    switch (letterToShow)
                    {
                        case "A":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_A, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "B":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_B, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "C":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_C, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "D":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_D, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "E":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_E, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "F":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_F, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "G":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_G, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "H":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_H, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "I":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_I, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "J":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_J, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "K":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_K, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "L":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_L, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "M":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_M, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "N":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_N, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "O":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_O, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "P":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_P, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "Q":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_Q, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "R":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_R, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "S":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_S, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "T":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_T, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "U":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_U, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "V":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_V, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "W":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_W, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "X":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_X, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "Y":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_Y, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "Z":
                            GUI.DrawTexture(new Rect(ScreenControl, Screen.height / 2, 60, 60), letter_Z, ScaleMode.StretchToFill, true, 0.0F);
                            break;
                        case "":

                            break;
                    }
                    ScreenControl += 35;
                }
            }*/

            /*GUI.backgroundColor = Color.clear;

            //We need to set up a next and restart screen

            if (Game_Manager.levelFinished == true)
            {
                GUI.DrawTexture(new Rect(Screen.width / 2 - 512, Screen.height / 2 - 384, 1024, 768), ScoreTexture, ScaleMode.StretchToFill, true, 0.0F);


                if (GUI.Button(new Rect(Screen.width / 2 - 300, Screen.height / 2, 128, 128), FacebookTexture))
                {
                    ShowFBClicked = true;
                }
                if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2, 128, 128), TweeterTexture))
                {
                    ShowTWClicked = true;
                }
                if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 256, 128), mainMenu))
                {
                    Invoke("GoMainMenu", 1.5f);
                    //Invoke("LoadNextLevel", 1.5f);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 150, Screen.height / 2, 256, 128), RestartTexture))
                {
                    Invoke("RestartGame", 1.5f);
                    //Invoke("LoadNextLevel", 1.5f);
                }
                if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2, 256, 128), NextLevel))
                {
                    //Invoke("RestartGame", 1.5f);
                    Invoke("LoadNextLevel", 1.5f);
                }



              
            }
        }
            
            
                /*string scoreTemp;
                string combCount;
                string eachNumber;
                int echaNumberInt;
                int controlSpace = 32;*/

            //scoreTemp = Game_Manager.scoreCounter.ToString();
            //scoreTemp = Score.scoreCounter.ToString();

            //Debug.Log(scoreTemp);
            /*for (int i = 0; i < scoreTemp.Length; i++)
            {
                eachNumber = scoreTemp.Substring(i, 1);
                echaNumberInt = int.Parse(eachNumber);

                switch (echaNumberInt)
                {
                    case 9:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_9, ScaleMode.StretchToFill, true, 0.0F);                      
                        break;
                    case 8:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_8, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 7:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_7, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 6:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_6, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 5:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_5, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 4:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_4, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 3:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_3, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 2:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_2, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 1:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 0:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 132, 32, 32), number_0, ScaleMode.StretchToFill, true, 0.0F);
                        break;

                    }
                controlSpace += 32;
                }

            controlSpace = 32;
           

                for (int i = 0; i < PlayerPrefs.GetInt("HighScore").ToString().Length; i++)
                {
                    eachNumber = PlayerPrefs.GetInt("HighScore").ToString().Substring(i, 1);
                    echaNumberInt = int.Parse(eachNumber);

                switch (echaNumberInt)
                {
                    case 9:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_9, ScaleMode.StretchToFill, true, 0.0F);                      
                        break;
                    case 8:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_8, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 7:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_7, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 6:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_6, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 5:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_5, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 4:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_4, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 3:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_3, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 2:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_2, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 1:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 0:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 76, 32, 32), number_0, ScaleMode.StretchToFill, true, 0.0F);
                        break;

                    }
                controlSpace += 32;
                }

                controlSpace = 32;*/

                //Number of combinations of this game
                 //combCount = Spawn_Script.combinationsCounter.ToString();
                 

            /*for (int i = 0; i < combCount.Length; i++)
            {
                eachNumber = combCount.Substring(i, 1);
                echaNumberInt = int.Parse(eachNumber);

                switch (echaNumberInt)
                {
                    case 9:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_9, ScaleMode.StretchToFill, true, 0.0F);                      
                        break;
                    case 8:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_8, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 7:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_7, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 6:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_6, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 5:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_5, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 4:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_4, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 3:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_3, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 2:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_2, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 1:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 0:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 - 21, 32, 32), number_0, ScaleMode.StretchToFill, true, 0.0F);
                        break;

                    }
                controlSpace += 32;
                }

            controlSpace = 32;

                 for (int i = 0; i < PlayerPrefs.GetInt("HighComb").ToString().Length; i++)
            {
                eachNumber = PlayerPrefs.GetInt("HighComb").ToString().Substring(i, 1);
                echaNumberInt = int.Parse(eachNumber);

                switch (echaNumberInt)
                {
                    case 9:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_9, ScaleMode.StretchToFill, true, 0.0F);                      
                        break;
                    case 8:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_8, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 7:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_7, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 6:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_6, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 5:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_5, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 4:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_4, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 3:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_3, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 2:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_2, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 1:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_1, ScaleMode.StretchToFill, true, 0.0F);
                        break;
                    case 0:
                        GUI.DrawTexture(new Rect((Screen.width / 2 + 90) + controlSpace, Screen.height / 2 + 35, 32, 32), number_0, ScaleMode.StretchToFill, true, 0.0F);
                        break;

                    }
                controlSpace += 32;
                }
                 controlSpace = 32;
                }
                }*/

       /* void GoMainMenu()
        {
            Objects_Hit_Player.ResetPicked();
            Application.LoadLevel("LEVEL_MAP");
        }

        void RestartGame()
        {          
                        
            Objects_Hit_Player.ResetPicked();
            Application.LoadLevel(Game_Manager.currentLevel);

            //Game_Manager.LoadNextLevel();
            //Application.LoadLevel("Stage_1");
        }

        void LoadNextLevel()
        {
            Score.comboCounter = 0;
            Game_Manager.LoadNextLevel();
        }*/
  }
      
           



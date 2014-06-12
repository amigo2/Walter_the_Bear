using UnityEngine;
using System.Collections;

public class StoryManager : MonoBehaviour {

    public Texture2D backButtonStoryTexture;
    public Texture2D backButtonStoryTextureClicked;

    public float autofadeTime = 0.5f;


    float originalWidth = 1024;
    float originalHeight = 720;

    public GameObject owl;
    public GameObject chuka;
    public GameObject walter;
    Animator owlAnimator;
    Animator chukaAnimator;
    Animator walterAnimator;


    public GUIText title;
    int next = 0;

    bool faded = false;


    

    

    Vector3 scale;

	// Use this for initialization
	void Start () 
    {
        TextInit();
        owlAnimator = owl.GetComponent<Animator>();
        chukaAnimator = chuka.GetComponent<Animator>();
        walterAnimator = walter.GetComponent<Animator>();
        
        //StartCoroutine(Fade.use.Colors(cube.renderer.material, Color.red, Color.white, 2.0f, EaseType.InOut));
        //StartCoroutine(StartFading());
      
	}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            StartCoroutine(Fade.use.Alpha(title.material, 1, 0, 0.2f));
            next++;

            if (next == 1)
            {
                Debug.Log("Clicked 1");
                owlAnimator.SetTrigger("talk");
                StartCoroutine(Fade.use.Alpha(title.material, 0, 1, 0.2f));
                title.guiText.text = "This is my imaginary friend Walter te Bear.. ";

            }
            if (next == 2)
            {
                Debug.Log("Clicked 2");
                owlAnimator.SetTrigger("idle");
				StartCoroutine(Fade.use.Alpha(title.material, 0, 1, 0.2f));
                title.guiText.text = "We always play together and have so much fun..";

            }
            if (next == 3)
            {
                Debug.Log("Clicked 2");
                owlAnimator.SetTrigger("idle");
                StartCoroutine(Fade.use.Alpha(title.material, 0, 1, 0.2f));
                title.guiText.text = "SCENE 2 WALTER GET LOST..";

            }
            if (next == 4)
            {
                Debug.Log("Clicked 2");
                owlAnimator.SetTrigger("idle");
                StartCoroutine(Fade.use.Alpha(title.material, 0, 1, 0.2f));
                title.guiText.text = "SCENE 3";

            }
            if (next == 5)
            {
                Debug.Log("Clicked 2");
                owlAnimator.SetTrigger("idle");
                StartCoroutine(Fade.use.Alpha(title.material, 0, 1, 0.2f));
                title.guiText.text = "“Where is Walter the bear.";

            }
        }

        
        
    }

    void TextInit()
    {
        float time = 2;
        float startAlpha = 0;
        float endAlpha = 1; 

        StartCoroutine(Fade.use.Alpha(title.material, startAlpha, endAlpha, 0.8f));
        title.guiText.text = "“Hi, my name is Chuka and I’m, 5..”";

        float fontSize = title.guiText.fontSize;
        fontSize = Screen.height / 18;
        title.guiText.fontSize = (int)fontSize;
        
        

    }

    public Vector2 ReadjustGUISize(float originalSizeX, float originalSizeY, float originalWidth, float originalHeight)
    {
        Vector2 newPos = new Vector2(originalSizeX * Screen.width / originalWidth, originalSizeY * Screen.height / originalHeight);

        return newPos;
    }

    /*private IEnumerator StartFading()
    {
        float time = 2;

        yield return Fade.use.Alpha(title.material, 0, 5, time);
        yield return new WaitForSeconds(4.0f);
        yield return Fade.use.Alpha(title.material, 5, 10, time);
        //Destroy(gameObject);

    }*/




    void OnGUI()
    {
        //Initialize values acording to screen size.
        scale.y = Screen.height / originalHeight;
        scale.x = scale.y;
        scale.z = 1;

        float scaleX = Screen.width / originalWidth;
        Matrix4x4 svMatrix = GUI.matrix;

        //Recalculate the matrix..
        GUI.matrix = Matrix4x4.TRS(new Vector3((scaleX - scale.y) / 2, 0, 0), Quaternion.identity, scale);

        GUI.backgroundColor = Color.clear;

        //if (GUI.Button(new Rect(Screen.width - 104, Screen.height - 104, backButtonStoryTexture.width, backButtonStoryTexture.height), backButtonStoryTexture))
        if (GUI.Button(new Rect( 950 - backButtonStoryTexture.width, 720 - backButtonStoryTexture.height, backButtonStoryTexture.width, backButtonStoryTexture.height), backButtonStoryTexture))
        {
            backButtonStoryTexture = backButtonStoryTextureClicked;
            //Application.LoadLevel("MAIN_MENU");
            AutoFade.LoadLevel("MAIN_MENU", autofadeTime, autofadeTime, Color.black);
        }

        GUI.color = Color.blue;
        //Close and return ne Matrix value.
        GUI.matrix = svMatrix;
    }

}

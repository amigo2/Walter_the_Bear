﻿using UnityEngine;
using System.Collections;


public class FadeC : MonoBehaviour
{

    public float fadeDuration = 3.0f;



    private float timeLeft = 0.0f;



    private float origRed = 0.0f;

    private float origGreen = 0.0f;

    private float origBlue = 0.0f;



    private void Awake()
    {

        timeLeft = fadeDuration;



        origBlue = guiText.font.material.color.b;

        origGreen = guiText.font.material.color.g;

        origRed = guiText.font.material.color.r;



        //Set Text to transparent

        guiText.font.material.color = new Color(origRed, origGreen, origBlue, 0);

    }



    private void Update()
    {

        if (timeLeft > 0)
        {

            //Fade in

            //Debug.Console("Fading in " + timeLeft);

            Fade(true);

        }

        else if (timeLeft > (-fadeDuration))
        {

            //Fade out

            //Debug.Console("Fading out ");

            Fade(false);

        }

        else
        {

           // DebugConsole.Log("Boom!");

            Destroy(gameObject);

        }

        timeLeft -= Time.deltaTime;

    }



    private void Fade(bool fadeIn)
    {

        if (fadeIn)
        {

            float a = guiText.font.material.color.a;

            a = (timeLeft / fadeDuration);

            if (a > 1) { a = 1; }

            guiText.font.material.color = new Color(origRed, origGreen, origBlue, 1 - a);

        }

        else
        {

            float a = guiText.font.material.color.a;

            a = timeLeft / (-fadeDuration);

            if (a < 0) { a = 0; }

            guiText.font.material.color = new Color(origRed, origGreen, origBlue, 1 - a);

        }

    }

}
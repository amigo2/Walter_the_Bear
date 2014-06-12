using UnityEngine;
using System.Collections;
using System;  // Needed for Math

public class Sinus : MonoBehaviour {

    //un-optimized version
    public double frequency = 440;
    public double gain = 0.05;

    private double increment;
    private double phase;
    private double sampling_frecuency = 48000;


	//Refers to on AudiofilterRead
    void OnAudioFilterRead(float[] data, int channels)
    {
        //update increment in case frecuency has changed
        increment = frequency * 2 * Math.PI / sampling_frecuency;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            phase = phase + increment;
            //This is where we copy the audio data to make them available to Unity
            data[i] = (float)(gain * Math.Sin(phase));
            //If we have stereo we cpy the data to both channels
            if (channels == 2) data[i + 1] = data[i];
            if (phase > 2 * Mathf.PI) phase = 0;

        }


    }
}

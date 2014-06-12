using UnityEngine;
using System.Collections;
using System;// Needs for Random


//White noise generator
public class WhiteNoise : MonoBehaviour {

    
    // Un- optimized version of a noise generator
    private System.Random GeneratorRandomNumber = new System.Random();

    public float offset = 0;

    void OnAudioFilterRead(float[] data, int channels)
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = offset - 1.0f + (float)GeneratorRandomNumber.NextDouble() * 2.0f;

        }

    }

}

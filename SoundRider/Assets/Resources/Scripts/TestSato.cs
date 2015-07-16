using UnityEngine;
using System.Collections;

public class TestSato : MonoBehaviour {

	AudioSource audio;
	RectTransform rectTransform;


	// Use this for initialization
	void Start()
	{
		
	}

	void Update()
	{

	}
//
//	float GetAveragedVolume()
//	{ 
//		float[] data = new float[256];
//		float a = 0;
//		audio.GetSpectrumData(data,0, FFTWindow.BlackmanHarris);
//		foreach(float s in data)
//		{
//			a += Mathf.Abs(s);
//		}
//		return a/256.0f;
//	}

}

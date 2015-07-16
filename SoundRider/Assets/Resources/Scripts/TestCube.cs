using UnityEngine;
using System.Collections;

public class TestCube : MonoBehaviour {

	private InputEX inputEx;

	// Use this for initialization
	void Start () 
	{
		inputEx = GameObject.FindGameObjectWithTag ("InputEX").GetComponent<InputEX>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (inputEx.SlideDirection == InputEX.eDirection.Right) 
		{
			transform.Translate (new Vector3(1.0f, 0.0f, 0.0f));
		}

		if (inputEx.SlideDirection == InputEX.eDirection.Left) 
		{
			transform.Translate (new Vector3(-1.0f, 0.0f, 0.0f));
		}

		if (inputEx.SlideDirection == InputEX.eDirection.Top) 
		{
			transform.Translate (new Vector3(0.0f, 1.0f, 0.0f));
		}

		if (inputEx.SlideDirection == InputEX.eDirection.Bottom) 
		{
			transform.Translate (new Vector3(0.0f, -1.0f, 0.0f));
		}
			
	}
}

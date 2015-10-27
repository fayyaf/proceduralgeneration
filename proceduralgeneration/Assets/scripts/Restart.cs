using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R))
		{
			Application.LoadLevel("scene01"); // Application.LoadLevel("myGameScene");
		}
	}
}

using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {


    float timer = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F1)) {
			Application.LoadLevel("myMenu");
		}
	}
}

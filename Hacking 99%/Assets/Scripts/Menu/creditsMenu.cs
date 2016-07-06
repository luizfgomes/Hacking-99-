using UnityEngine;
using System.Collections;

public class creditsMenu : MonoBehaviour {
	private float selectOption = 1.0f;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown ("enter") && gameObject) {
			Destroy(gameObject);			
		}
		
		if (Input.GetKeyDown ("escape")) {
			selectOption=selectOption-1;
			Destroy(gameObject);
		}
	}
}

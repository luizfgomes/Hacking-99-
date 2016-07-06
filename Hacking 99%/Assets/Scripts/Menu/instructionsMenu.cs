using UnityEngine;
using System.Collections;

public class instructionsMenu : MonoBehaviour {
	private float selectOption = 1.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			selectOption=selectOption+1;
			
		}
		
		if (Input.GetKeyDown ("escape")) {
			selectOption=selectOption-1;
			Destroy(gameObject);
		}
	}
}

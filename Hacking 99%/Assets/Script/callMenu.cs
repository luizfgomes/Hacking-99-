using UnityEngine;
using System.Collections;

public class callMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Application.LoadLevel("menu");
		}
	}
}

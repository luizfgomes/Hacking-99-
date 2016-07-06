using UnityEngine;
using System.Collections;

public class vitoriaF2 : MonoBehaviour {
	
	void Update () {
		if (Input.GetKey (KeyCode.F1)) {
			Application.LoadLevel("CS3");
		}		
	}
}

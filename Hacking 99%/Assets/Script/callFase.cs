using UnityEngine;
using System.Collections;

public class callFase : MonoBehaviour {

	void Update(){
		if (Input.GetMouseButtonDown(0)){
			Application.LoadLevel("jogo");
		}
	}
}

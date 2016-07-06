using UnityEngine;
using System.Collections;

public class select_fase : MonoBehaviour {
	static public bool unlockFase2 = false;
	static public bool unlockFase3 = false;
	private float selectOption = 2;
	private float selectMenu = 0;
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp ("up")) {
			if (selectMenu>=1 && selectOption==1 ){
				selectMenu=selectMenu-1;
			}
		}

		if (Input.GetKeyUp ("down")) {
			if (selectMenu <= 2 && selectOption == 1) {
				selectMenu=selectMenu+1;
			}
		}

		if (Input.GetKeyDown(KeyCode.Return)) {
			selectOption=selectOption+1;
			if(selectOption==3 && Input.GetKeyDown(KeyCode.Return))
            {


				if (selectMenu==0){
					Application.LoadLevel("CS1");
				}
				if (selectMenu==1 && unlockFase2 == true){
					Application.LoadLevel("cena2");
				}
				if (selectMenu==2 && unlockFase3 == true){
					Application.LoadLevel("cena3");
				}
				if (selectMenu==3){
					Application.LoadLevel("arcade");
				}
			}

		}
		
		if (Input.GetKeyDown ("escape")) {
				Destroy(gameObject);
				selectOption=selectOption-1;
		}
	}
}

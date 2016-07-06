using UnityEngine;
using System.Collections;

public class popUp : MonoBehaviour {

	
	private GameObject getDown;

	void Start(){
		getDown = GameObject.FindWithTag("Player1");
	}


	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3(getDown.transform.position.x + 5f, getDown.transform.position.y - 4f, gameObject.transform.position.z);
		Destroy (gameObject, 6);

	}
	

}

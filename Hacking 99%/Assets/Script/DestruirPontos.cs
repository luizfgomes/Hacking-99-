using UnityEngine;
using System.Collections;

public class DestruirPontos : MonoBehaviour {

	void OnCollisionEnter(Collision colisor){
		if (colisor.gameObject.tag == "Player") {
			print ("Teste");
		}
	}
}

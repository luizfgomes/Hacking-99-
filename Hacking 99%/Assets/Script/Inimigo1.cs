using UnityEngine;
using System.Collections;

public class Inimigo1 : MonoBehaviour {
	private float velocidade = 5;
	bool point = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Vector2.up * velocidade * Time.deltaTime);

		if (transform.position.y <= -4.5f && point == true) {
			addPonto.pontos = addPonto.pontos + 1;
			point = false;
		}

		if (transform.position.y <= -6){
			Destroy (gameObject);
		}


	}
}

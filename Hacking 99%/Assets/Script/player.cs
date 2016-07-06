using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float velocidade;
	//public Transform player1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Movimentacao ();

		if (transform.position.x <= - 3.8 || transform.position.x >= 3.8) {
			Application.LoadLevel("Morreu");
		}


	}

	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "inimigo") {
			Application.LoadLevel("morreu");
		}

		if (colisor.gameObject.tag == "ponto") {
			addPonto.pontos=addPonto.pontos+1;
		}
	}
	

	void Movimentacao (){
		if (Input.GetAxisRaw ("Horizontal") > 0){
			transform.Translate (Vector2.right * velocidade * Time.deltaTime);
		}

		if (Input.GetAxisRaw ("Horizontal") < 0){
			transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
		}
	}
}

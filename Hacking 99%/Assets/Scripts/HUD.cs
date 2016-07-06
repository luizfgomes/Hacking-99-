using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	public GameObject n100;
	public GameObject n90;

	// Use this for initialization
	void Start () {
		Instantiate(n100, new Vector3(0, 0, -2), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 90) {
			Destroy(n100);
			Instantiate(n90, new Vector3(0, 0, -2), Quaternion.identity);
		}
		if (spawnFase1.LifePlayer == 80) {


		}
		if (spawnFase1.LifePlayer == 70) {
		
		}
		if (spawnFase1.LifePlayer == 60) {

		}
		if (spawnFase1.LifePlayer == 50) {

		}
		if (spawnFase1.LifePlayer == 40) {

		}
		if (spawnFase1.LifePlayer == 30) {

		}
		if (spawnFase1.LifePlayer == 20) {
			Destroy (GameObject.Find ("100"));
		}
		if (spawnFase1.LifePlayer == 10) {
			Destroy (GameObject.Find ("100"));
		}


	}
}

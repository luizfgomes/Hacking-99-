using UnityEngine;
using System.Collections;

public class life100 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		spawnFase1.LifePlayer = 100;
		spawnFase2.LifePlayer = 100;
		spawn.LifePlayer = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 90 || spawnFase2.LifePlayer == 90 || spawn.LifePlayer == 90) {
			Destroy(gameObject);
		}
	}
}

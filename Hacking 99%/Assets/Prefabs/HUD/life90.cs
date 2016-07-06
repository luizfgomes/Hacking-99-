using UnityEngine;
using System.Collections;

public class life90 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 80 || spawnFase2.LifePlayer == 80 || spawn.LifePlayer == 80) {
			Destroy(gameObject);
		}
	}
}

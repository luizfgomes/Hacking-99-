using UnityEngine;
using System.Collections;

public class life60 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 50 || spawnFase2.LifePlayer == 50 || spawn.LifePlayer == 50) {
			Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class life30 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 20 || spawnFase2.LifePlayer == 20 || spawn.LifePlayer == 20) {
			Destroy(gameObject);
		}
	}
}

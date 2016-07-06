using UnityEngine;
using System.Collections;

public class life50 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 40 || spawnFase2.LifePlayer == 40 || spawn.LifePlayer == 40) {
			Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class life20 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 10 || spawnFase2.LifePlayer == 10 || spawn.LifePlayer == 10) {
			Destroy(gameObject);
		}
	}
}

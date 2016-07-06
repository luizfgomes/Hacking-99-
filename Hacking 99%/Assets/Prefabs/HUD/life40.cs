using UnityEngine;
using System.Collections;

public class life40 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 30 || spawnFase2.LifePlayer == 30 || spawn.LifePlayer == 30) {
			Destroy(gameObject);
		}
	}
}

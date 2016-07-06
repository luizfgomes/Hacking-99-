using UnityEngine;
using System.Collections;

public class life80 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 70 || spawnFase2.LifePlayer == 70 || spawn.LifePlayer == 70) {
			Destroy(gameObject);
		}
	}
}

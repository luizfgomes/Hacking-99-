﻿using UnityEngine;
using System.Collections;

public class life70 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnFase1.LifePlayer == 60 || spawnFase2.LifePlayer == 60 || spawn.LifePlayer == 60) {
			Destroy(gameObject);
		}
	}
}
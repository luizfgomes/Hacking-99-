using UnityEngine;
using System.Collections;

public class VitoriaFinal : MonoBehaviour {


    float timer = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Application.LoadLevel(1);
        }
	}
}

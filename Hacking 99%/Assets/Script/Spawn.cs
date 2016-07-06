using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject inimigo;
	private bool teste = true;

	private Vector3 SpawnPoint;
	// Use this for initialization
	void Start () {
		StartCoroutine (Timer ());
		Invoke ("spawnInimigos", 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (teste == true) {
			Timer ();
			InvokeRepeating("spawnInimigos", 1,0.5f);
			teste =false;
		}
	}

	IEnumerator Timer(){
		teste = false;
		print (teste);
		yield return new WaitForSeconds (5);
		spawnInimigos ();
		teste = true;
		print (teste);

	}

	void spawnInimigos() {
		SpawnPoint.x = Random.Range(-3.7f, 3.7f);
		SpawnPoint.y = Random.Range (5f,11f);
		SpawnPoint.z = 0;
		Instantiate (inimigo, new Vector3 (SpawnPoint.x, SpawnPoint.y, SpawnPoint.z),Quaternion.identity);

	}


}

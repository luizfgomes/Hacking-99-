//Script que fara o video dar play e aguardara o imput do player para apertar o botao responsavel para a proxima tela
using UnityEngine;
using System.Collections;

public class Cutscene4: MonoBehaviour {
	AudioSource audio;
	
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		audio = GetComponent<AudioSource>();
		audio.Play ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F1)) {
			Application.LoadLevel("myMenu");
		}
		
	}
}
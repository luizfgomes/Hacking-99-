using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ranking : MonoBehaviour {
	public Text arcadeText1;
	public Text arcadeText2;
	private float pontuacaoTop;

	public static float pontuacaoRArcade1;
	public static float pontuacaoRArcade2;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F1)){
			Application.LoadLevel("myMenu");
		}
		if (pontuacaoTop <= Player.pontuacaoArcade) {
			pontuacaoTop = Player.pontuacaoArcade;
			arcadeText1.text = pontuacaoTop.ToString ();
		} else {
			pontuacaoTop = pontuacaoTop;
		}
		arcadeText2.text = Player.pontuacaoArcade.ToString();

	}
}

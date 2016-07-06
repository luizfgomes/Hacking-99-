using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {
	public Text pontos1Text;
	public Text pontos2Text;
	public Text pontos3Text;
	private int pontos11 = addPonto.valor1;
	private int pontos22 = addPonto.valor2;
	private int pontos33 = addPonto.valor3;
	//public static int pontos1 = addPonto.pontos;
	//public static int pontos2 = addPonto.valor2;
	//public static int pontos3 = addPonto.valor3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		pontos1Text.text = "Pontos: " + pontos11.ToString ();
		pontos2Text.text = "Pontos: " + pontos22.ToString ();
		pontos3Text.text = "Pontos: " + pontos33.ToString ();
		//print (pontos333);
	}
}

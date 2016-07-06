using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class addPonto : MonoBehaviour {
	public Text pontosText;
	public static int pontos = 0;
	public static int valor1 = 0;
	public static int valor2 = 0;
	public static int valor3 = 0;
	private bool sim = true;
	private bool sim2 = true;
	void Start(){
		pontosText.text = "Pontos: " + pontos.ToString ();
	}

	void Update(){
		pontosText.text = "Pontos: " + pontos.ToString ();
		pontoss ();
	}
		
	void pontoss(){
		if (pontos > valor1) {
			valor1 = pontos;
			print ("Valor1" + valor1);
			sim=false;
			sim2 = false;
		} else if (pontos > valor2 && sim == true) {
			valor2 = pontos;
			print ("Valor2" + valor2);
			sim2= false;
		} else if ( valor2 > valor3 ) {
			valor3 = pontos;
			print ("Valor3"+valor3);
		}
	}

	void OnCollisionEnter(Collision target)
	{
		if(target.gameObject.tag == "Player")
		{
			print ("Acertou");
		}
	}


}

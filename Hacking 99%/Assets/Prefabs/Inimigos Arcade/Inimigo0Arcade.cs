using UnityEngine;
using System.Collections;

public class Inimigo0Arcade : MonoBehaviour {

	private Inim01IA dmg01;
	public GameObject explosao;
	public GameObject player;
	private bool podeAtacar = true;
	private Transform inimigo;
	private bool seguirPlayer = false;
	public bool lostPlayer = true;
	private int pontos = 0;
    public int LifePlayer;
	public int inim02Life = 100;
	
	
	
	void Awake()
	{
		dmg01 = GameObject.FindGameObjectWithTag("inimigo00").GetComponent<Inim01IA>() as Inim01IA;
	}
	
	// Use this for initialization
	void Start()
	{
		inimigo = GetComponent<Transform> ();
	}
	void InstanciaExplosao()
	{
		Instantiate(explosao, transform.position, Quaternion.identity);
	}
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Tiro") {
			inim02Life-= 10;
		}
	}

	// Update is called once per frame
	void Update()
	{
        LifePlayer = Player.playerLife;

		if (inim02Life ==0){
			Destroy(gameObject);
			print ("morreu");
			pontos += 10;
			print (pontos);
		}


		if (seguirPlayer == true) {
			inimigo.position = Vector3.Lerp (inimigo.position, player.transform.position, 0.03f);
		}
		if(Vector3.Distance(transform.position, player.transform.position) < 1.5f){
			Debug.Log("Esta perto");
			Atacar ();
		}
		if (dmg01.getVida() <= 0)
		{
			// Criando o efeito de partícula.
			Invoke("InstanciaExplosao", 1);
			
			// Criando o som da explosão.
			Destroy(gameObject);
		}
	}
	
	void Atacar(){
		if (podeAtacar == true) {
			StartCoroutine ("TempoDeAtaque");
			LifePlayer -= 10;
		}
	}
	
	IEnumerator TempoDeAtaque(){
		podeAtacar = false;
		yield return new WaitForSeconds (2);
		podeAtacar = true;
	}
	
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			seguirPlayer = true;
			Debug.Log("LOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL");
		}
	}
	
	void OnTriggerExit2D(Collider2D col) {
		if (col.tag == "Player") {
			seguirPlayer = false;
		}
	} 

    
}


using UnityEngine;
using System.Collections;

public class Inimigo00ia : MonoBehaviour
{
	public GameObject player;
	public GameObject inimigoHome;
	//private Transform player;
	private Transform playerPS;
	private Vector3 positionPlayerLost;
	private Vector3 positionPlayerFind;
	public Vector3 frontPos;
	private EnemyShot tiroInim;
	public GameObject explosao;
	
	public bool lostPlayer = true;
	public bool canFly = false;
	
	public int inim02Life = 100;
	
	
	void Start()
	{
		tiroInim = GetComponentInChildren<EnemyShot>() as EnemyShot;
		//player = GameObject.FindGameObjectWithTag("Player1").transform;
	}
	
	void Update()
	{
		if (inim02Life ==0){
			Destroy(gameObject);
			print ("morreu");
		}
		
		if (lostPlayer)
		{
			//gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.position, 0.02f);
			tiroInim.Attack();
		}
		
		//frontPos = player.position;
		transform.rotation = Quaternion.LookRotation(Vector3.forward, frontPos - transform.position);
		
		if (getVida() <= 0)
		{
			// Criando o efeito de partícula.
			Instantiate(explosao, transform.position, Quaternion.identity);
			
			// Criando o som da explosão.
			Destroy(gameObject);
		}
	}
	
	
	void OnCollisionEnter2D(Collision2D colisor)
	{
		if (colisor.gameObject.tag == "Tiro")
		{
			menosVida(10);
		}
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player1")
		{
			lostPlayer = false;
		}
	}
	
	public void menosVida(int vida)
	{
		inim02Life -= vida;
	}
	
	public int getVida()
	{
		return inim02Life;
	}
}

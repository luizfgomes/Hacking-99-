using UnityEngine;
using System.Collections;

public class spawnArcade : MonoBehaviour
{
	public bool coreV = true;
	public GameObject core;
	public GameObject core2;
	public GameObject inim00;
	public GameObject inim01;
	public GameObject inim02;
	public GameObject inim03;
	public GameObject inim04;
	public GameObject inim05;

	
	int contadorCore;
	public int coreLife = 100;
	public int coreContagem;
	public int inimContagem;
	public float spawnWait;
	public float startWait;
	
	
	public Vector2 spawnValues1;
	public Vector2 spawnEnemy00;
	public Vector2 spawnEnemy01;
	public Vector2 spawnEnemy02;
	public Vector2 spawnEnemy03;
	public Vector2 spawnEnemy04;
	public Vector2 spawnEnemy05;
	
	// Use this for initialization
	void Start()
	{
		contadorCore = Random.Range(1, 1);
		StartCoroutine(SpawnCore());
	}
	
	IEnumerator SpawnCore()
	{
		
		for (int i = 0; i < coreContagem; i++)
		{
			
			Debug.Log(contadorCore);
			if (contadorCore == 1 && coreV == true)
			{
				contadorCore = Random.Range(2, 3);
				Vector2 spawnPosition1 = new Vector2(spawnValues1.x, spawnValues1.y);
				Quaternion spawnRotation1 = Quaternion.identity;
				Instantiate(core, spawnPosition1, spawnRotation1);
				yield return new WaitForSeconds(spawnWait);
				coreV=false;
			}
			if (contadorCore == 1 && coreV == false)
			{
				contadorCore = Random.Range(2, 3);
				Vector2 spawnPosition1 = new Vector2(spawnValues1.x, spawnValues1.y);
				Quaternion spawnRotation1 = Quaternion.identity;
				Instantiate(core2, spawnPosition1, spawnRotation1);
				yield return new WaitForSeconds(spawnWait);
				coreV=true;
			}
		}
		
		while (coreLife > 0)
		{
			yield return new WaitForSeconds(startWait);
			for (int i = 0; i < inimContagem; i++)
			{
				int randomEnemy = Random.Range(1, 5);
				Debug.Log(randomEnemy);
				Quaternion spawnRotation = Quaternion.identity;
				if (randomEnemy == 1)
				{
					Instantiate(inim00, spawnEnemy00, spawnRotation);
				}
				else if (randomEnemy == 2)
				{
					Instantiate(inim01, spawnEnemy01, spawnRotation);
				}
				else if (randomEnemy == 3)
				{
					Instantiate(inim02, spawnEnemy02, spawnRotation);
				}
				else if (randomEnemy == 4)
				{
					Instantiate(inim03, spawnEnemy03, spawnRotation);
				}
				else if (randomEnemy == 5)
				{
					Instantiate(inim04, spawnEnemy03, spawnRotation);
				}
				else if (randomEnemy == 6)
				{
					Instantiate(inim05, spawnEnemy03, spawnRotation);
				}
				yield return new WaitForSeconds(spawnWait);
			}
		}
	}
	public void InstanciaPowerUpDefesa()
	{
		Debug.Log("teta");
		CancelInvoke ();
	}
	
	public void InstanciaPowerUpVida()
	{
		Debug.Log("teta3");
		CancelInvoke ();
	}
	
	public void InstanciaPowerUpSpeed()
	{
		Debug.Log("teta2");
		CancelInvoke ();
	}
	public void menosVida(int vida)
	{
		coreLife -= vida;
	}
	
	public int getVida()
	{
		return coreLife;
	}
	void Update()
	{
		if (coreLife == 0) {
			Destroy (core);
		}
	}
}

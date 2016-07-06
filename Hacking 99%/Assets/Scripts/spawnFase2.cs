using UnityEngine;
using System.Collections;

public class spawnFase2 : MonoBehaviour {

	public GameObject core01;
    public GameObject powerUpVida;
    public GameObject inim00;
    public GameObject inim01;
    public GameObject inim02;
    public GameObject inim03;
    public static int LifePlayer;


    float timerFase = 180f;
    int contadorCore;
	public int coreLife = 100;
	public int coreContagem;
	public int inimContagem;
	public float spawnWait;
	public float startWait;
	
	
	public Vector2 spawnCore;
    public Vector2 spawnEnemy00;
    public Vector2 spawnEnemy01;
    public Vector2 spawnEnemy02;
    public Vector2 spawnEnemy03;
	public Vector2 spawnPowerUpVida;

    // Use this for initialization
    void Start()
	{
		LifePlayer = 100;
		contadorCore = Random.Range(1, 1);
		StartCoroutine(SpawnCore());
		InvokeRepeating("InstanciaPowerUpVida",30f, 1);
	}
	
	IEnumerator SpawnCore()
	{
		
		for (int i = 0; i < coreContagem; i++)
		{
			
			Debug.Log(contadorCore);
			if (contadorCore == 1)
			{
				Vector2 spawnPosition1 = new Vector2(spawnCore.x, spawnCore.y);
				Quaternion spawnRotation1 = Quaternion.identity;
				Instantiate(core01, spawnPosition1, spawnRotation1);
				yield return new WaitForSeconds(spawnWait);
			}
		}
		
		while (coreLife > 0)
		{
			yield return new WaitForSeconds(startWait);
			for (int i = 0; i < inimContagem; i++)
			{
				int randomEnemy = Random.Range(2, 5);
				Debug.Log(randomEnemy);
				Quaternion spawnRotation = Quaternion.identity;
                if (randomEnemy == 2)
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

                yield return new WaitForSeconds(spawnWait);
			}
		}
	}
    public void InstanciaPowerUpVida()
    {
        Instantiate(powerUpVida, spawnPowerUpVida, Quaternion.identity);
		CancelInvoke ();
    }
    public void menosVida(int vida )
	{
		coreLife -= vida;
	}
	
	public int getVida()
	{
		return coreLife;
	}
	void Update()
	{
        LifePlayer = Player.playerLife;
        if (LifePlayer <= 0)
        {
			Application.LoadLevel("GameOver");
        }
        timerFase -= Time.deltaTime;
		if (timerFase < 0)
		{
			coreLife = 0;
			Application.LoadLevel("GameOver");

		}
		if (coreLife <= 0)
		{
			Application.LoadLevel("vitoriaF2");
			menu.fase3ok = true;
		}
	}
}


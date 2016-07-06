using UnityEngine;
using System.Collections;

public class spawnFase1 : MonoBehaviour
{
    public GameObject core;
    public GameObject powerUpSpeed;
    public GameObject powerUpDefesa;
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


    public Vector2 spawnValues1;
    public Vector2 spawnEnemy00;
    public Vector2 spawnEnemy01;
    public Vector2 spawnEnemy02;
    public Vector2 spawnEnemy03;
    public Vector2 spawnPowerUpDefesa;
    public Vector2 spawnPowerUpSpeed;
    public Vector2 spawnPowerUpVida;

    // Use this for initialization
    void Start()
    {
		Player.pontuacaoArcade = 0;
		LifePlayer = 100;
        InvokeRepeating("InstanciaPowerUpSpeed", 5f, 1);
        InvokeRepeating("InstanciaPowerUpDefesa", 10f, 1);
        InvokeRepeating("InstanciaPowerUpVida", 15f, 1);
        contadorCore = Random.Range(1, 1);
        StartCoroutine(SpawnCore());
    }


 

    IEnumerator SpawnCore()
    {

        for (int i = 0; i < coreContagem; i++)
        {
            if (contadorCore == 1)
            {
                contadorCore = Random.Range(2, 3);
                Vector2 spawnPosition1 = new Vector2(spawnValues1.x, spawnValues1.y);
                Quaternion spawnRotation1 = Quaternion.identity;
                Instantiate(core, spawnPosition1, spawnRotation1);
                yield return new WaitForSeconds(spawnWait);
            }
        }

        while (coreLife > 0)
        {
            yield return new WaitForSeconds(startWait);
            for (int i = 0; i < inimContagem; i++)
            {
                int randomEnemy = Random.Range(1, 5);
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
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
    public void InstanciaPowerUpDefesa()
    {
        Instantiate(powerUpDefesa, spawnPowerUpDefesa, Quaternion.identity);
		CancelInvoke ();
    }

    public void InstanciaPowerUpVida()
    {
        Instantiate(powerUpVida, spawnPowerUpVida, Quaternion.identity);
		CancelInvoke ();
    }
    
    public void InstanciaPowerUpSpeed()
    {
        Instantiate(powerUpSpeed, spawnPowerUpSpeed, Quaternion.identity);
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
        LifePlayer = Player.playerLife;
        if (LifePlayer <= 0)
        {
			Application.LoadLevel("Ranking");
        }
        timerFase -= Time.deltaTime;
        if (timerFase < 0)
        {
            coreLife = 0;
			Application.LoadLevel("GameOver");
        }
		if(coreLife <= 0)
		{
			Application.LoadLevel("vitoriaF1");
			menu.fase2ok=true;
			Player.pontuacaoGame=Player.pontuacaoGame + 1200;
			Player.pontuacaoGame=Player.pontuacaoGame * timerFase;
		}
    }
}

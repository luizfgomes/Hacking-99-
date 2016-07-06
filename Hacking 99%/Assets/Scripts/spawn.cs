using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
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


    public Vector2 spawnValues2;
    public Vector2 spawnValues3;
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
		LifePlayer = 100;
        InvokeRepeating("InstanciaPowerUpDefesa", 45f, 1);
        InvokeRepeating("InstanciaPowerUpSpeed", 90f, 1);
        InvokeRepeating("InstanciaPowerUpVida", 135f, 1);
        contadorCore = Random.Range(2, 4);
        StartCoroutine(SpawnCore());
    }

    IEnumerator SpawnCore()
    {

        for (int i = 0; i < coreContagem; i++)
        {

            Debug.Log(contadorCore);
                 
            if (contadorCore == 2)
            {
                contadorCore = Random.Range(3, 3);
                Vector2 spawnPosition2 = new Vector2(spawnValues2.x, spawnValues2.y);
                Quaternion spawnRotation2 = Quaternion.identity;
                Instantiate(core, spawnPosition2, spawnRotation2);
                yield return new WaitForSeconds(spawnWait);
            }
            else if (contadorCore == 3)
            {
                contadorCore = Random.Range(1, 1);
                Vector2 spawnPosition3 = new Vector2(spawnValues3.x, spawnValues3.y);
                Quaternion spawnRotation3 = Quaternion.identity;
                Instantiate(core, spawnPosition3, spawnRotation3);
                yield return new WaitForSeconds(spawnWait);
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
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
	public void InstanciaPowerUpDefesa()
	{
		Instantiate (powerUpDefesa, spawnPowerUpDefesa, Quaternion.identity);
        CancelInvoke("InstanciaPowerUpDefesa");
	}

    public void InstanciaPowerUpVida()
    {
        Instantiate(powerUpVida, spawnPowerUpVida, Quaternion.identity);
        CancelInvoke("InstanciaPowerUpVida");
    }

    public void InstanciaPowerUpSpeed()
    {
        Instantiate(powerUpSpeed, spawnPowerUpSpeed, Quaternion.identity);
        CancelInvoke("InstanciaPowerUpSpeed");
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
        if(LifePlayer <= 0)
        {
			Application.LoadLevel("GameOver");
        }

        timerFase -= Time.deltaTime;
        if(timerFase <= 0 )
        {
			Application.LoadLevel("GameOver");
        }
        if(coreLife <= 0)
        {
			Player.pontuacaoRecord = Player.pontuacaoGame;
			Player.pontuacaoGame=0;
            Application.LoadLevel("CS4");
			menu.arcadeok = true;
        }
    }
}

using UnityEngine;
using System.Collections;

public class Inim02IA : MonoBehaviour {

    public GameObject inimigoHome;
    private Transform player;
    private Transform playerPS;
    private Vector3 positionPlayerLost;
    private Vector3 positionPlayerFind;
    public Vector3 frontPos;
    private EnemyShot tiroInim;
    public GameObject explosao;
    Animator anim;



    public float speed;
    private float startTime;
    private float journeyLenght;

    public bool lostPlayer = true;
    public bool canFly = false;

    public int inim02Life = 100;

    void Start()
    {
        anim = GetComponent<Animator>();
        tiroInim = GetComponentInChildren<EnemyShot>() as EnemyShot;
        player = GameObject.FindGameObjectWithTag("Player1").transform;
        positionPlayerLost = inimigoHome.transform.position;
        BackToHome();
    }

    void Update()
    {
        if (canFly)
        {
            if (lostPlayer)
            {
                float dist = (Time.time - startTime) * speed;
                float journey = dist / journeyLenght;

                if (gameObject.transform.position == inimigoHome.transform.position)
                    canFly = false;

                gameObject.transform.position = Vector3.Lerp(positionPlayerLost, inimigoHome.transform.position, journey);
            }
            else {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.position, 0.03f);
                tiroInim.Attack();
            }
        }
        frontPos = player.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, frontPos - transform.position);

        if (getVida() <= 0)
        {
            // Criando o efeito de partícula.
            Instantiate(explosao, transform.position, Quaternion.identity);

            // Criando o som da explosão.
            Destroy(gameObject);
			Player.pontuacaoGame=Player.pontuacaoGame + 10;
        }
    }

    public void BackToHome()
    {
        startTime = Time.time;
        positionPlayerLost = gameObject.transform.position;
        journeyLenght = Vector3.Distance(positionPlayerLost, inimigoHome.transform.position);
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Tiro")
        {
            anim.SetBool("levouDano", true);
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
    public void levouDano()
    {
        anim.SetBool("levouDano", false);
    }
}

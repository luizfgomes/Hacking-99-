using UnityEngine;
using System.Collections;

public class Inim01IAF2 : MonoBehaviour {

    private Transform player;
    private bool podeAtacar = true;
    private bool seguirPlayer = false;
    public GameObject explosao;
    public int inim01Life = 100;
    public float speed;
    Animator anim;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player1").transform;
    }
    // Update is called once per frame
    void Update()
    {
        if (seguirPlayer == true)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, player.transform.position, 0.02f);
        }
        if (Vector3.Distance(transform.position, player.transform.position) < 1.5f)
        {
            Debug.Log("Esta perto");
            Atacar();
        }
        if (getVida() <= 0)
        {
            // Criando o efeito de partícula.
            Invoke("InstanciaExplosao", 1);

            // Criando o som da explosão.
            Destroy(gameObject);
			Player.pontuacaoGame=Player.pontuacaoGame + 100;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Tiro")
        {
            anim.SetBool("levouDano", true);
            menosVida(25);
        }
    }

    void Atacar()
    {
        if (podeAtacar == true)
        {
            StartCoroutine("TempoDeAtaque");
            player.GetComponent<Player>().menosVida(25);
        }
    }

    IEnumerator TempoDeAtaque()
    {
        podeAtacar = false;
        yield return new WaitForSeconds(2);
        podeAtacar = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            seguirPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            seguirPlayer = false;
        }
    }

    void InstanciaExplosao()
    {
        Instantiate(explosao, transform.position, Quaternion.identity);
    }

    public void menosVida(int vida)
    {
        inim01Life -= vida;
    }

    public int getVida()
    {
        return inim01Life;
    }
    public void levouDano()
    {
        anim.SetBool("levouDano", false);
    }
}

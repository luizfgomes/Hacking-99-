using UnityEngine;
using System.Collections;

public class NucleoBugFase1 : MonoBehaviour
{
    public GameObject explosao;
    private spawnFase1 sc;
    Animator anim;

    void Awake()
    {
        sc = GameObject.FindGameObjectWithTag("coreFase1").GetComponent<spawnFase1>() as spawnFase1;
    }

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Tiro")
        {
            anim.SetBool("levouDano", true);
            sc.menosVida(5);
        }
    }
    public void levouDano()
    {
        anim.SetBool("levouDano", false);
    }
    // Update is called once per frame
    void Update()
    {

        if (sc.getVida() <= 0)
        {
            Instantiate(explosao, transform.position, Quaternion.identity);

            // Criando o som da explosão.
            Destroy(gameObject);
			select_fase.unlockFase2 = true;
        }
    }

}


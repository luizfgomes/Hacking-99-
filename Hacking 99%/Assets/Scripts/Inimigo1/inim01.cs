using UnityEngine;
using System.Collections;

public class inim01 : MonoBehaviour
{
    private Inim01IA dmg01;
    public GameObject explosao;

    void Awake()
    {
        dmg01 = GameObject.FindGameObjectWithTag("inimigo01").GetComponent<Inim01IA>() as Inim01IA;
    }

    // Use this for initialization
    void Start()
    {

    }
    void InstanciaExplosao()
    {
        Instantiate(explosao, transform.position, Quaternion.identity);
    }
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Tiro") {
			dmg01.menosVida(10);
		}
	}
    // Update is called once per frame
    void Update()
    {

        if (dmg01.getVida() <= 0)
        {
            // Criando o efeito de partícula.
            Invoke("InstanciaExplosao", 1);

            // Criando o som da explosão.
            Destroy(gameObject);
        }
    }

}

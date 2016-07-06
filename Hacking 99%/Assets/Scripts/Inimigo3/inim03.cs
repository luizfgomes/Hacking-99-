using UnityEngine;
using System.Collections;

public class inim03 : MonoBehaviour
{

    private Inim03IA dmg03;
    public GameObject explosao;

    void Awake()
    {
        dmg03 = GameObject.FindGameObjectWithTag("inimigo03").GetComponent<Inim03IA>() as Inim03IA;
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
			dmg03.menosVida(10);
		}
	}
    // Update is called once per frame
    void Update()
    {

        if (dmg03.getVida() <= 0)
        {
            // Criando o efeito de partícula.
            Invoke("InstanciaExplosao", 1);

            // Criando o som da explosão.
            Destroy(gameObject);
        }
    }
}

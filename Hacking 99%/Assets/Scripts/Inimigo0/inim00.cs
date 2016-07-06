using UnityEngine;
using System.Collections;

public class inim00 : MonoBehaviour
{
    private Inim00IA dmg00;
    public GameObject explosao;

    void Awake()
    {
        dmg00 = GameObject.FindGameObjectWithTag("inimigo00").GetComponent<Inim00IA>() as Inim00IA;
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
			dmg00.menosVida(10);
		}
	}
    // Update is called once per frame
    void Update()
    {

        if (dmg00.getVida() <= 0)
        {
            // Criando o efeito de partícula.
            Invoke("InstanciaExplosao", 1);


            // Criando o som da explosão.
            Destroy(gameObject);
        }
    }

}
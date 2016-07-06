using UnityEngine;
using System.Collections;

public class inim02 : MonoBehaviour
{
    private Inim02IA dmg02;
    public GameObject explosao;

    void Awake()
    {
        dmg02 = GameObject.FindGameObjectWithTag("inimigo02").GetComponent<Inim02IA>() as Inim02IA;
    }

    // Use this for initialization
    void Start()
    {

    }
    
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Tiro") {
			dmg02.menosVida(10);
		}
	}
    // Update is called once per frame
    void Update()
    {

        if (dmg02.getVida() <= 0)
        {
            // Criando o efeito de partícula.
			Instantiate(explosao, transform.position, Quaternion.identity);

            // Criando o som da explosão.
            Destroy(gameObject);
        }
    }

}
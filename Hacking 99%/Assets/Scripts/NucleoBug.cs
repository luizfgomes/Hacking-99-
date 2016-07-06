using UnityEngine;
using System.Collections;

public class NucleoBug : MonoBehaviour
{
    public GameObject explosao;
    private spawn sc;

    void Awake()
    {
        sc = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawn>() as spawn;
    }

    // Use this for initialization
    void Start()
    {

    }
	void OnCollisionEnter2D(Collision2D colisor){
		if (colisor.gameObject.tag == "Tiro") {
			sc.menosVida(5);
		}
	}
	// Update is called once per frame
	void Update ()
    {
       
        if (sc.getVida() <= 0)
        {
			Instantiate(explosao, transform.position, Quaternion.identity);

            // Criando o som da explosão.
            Destroy(gameObject);
        }
    }
    
}

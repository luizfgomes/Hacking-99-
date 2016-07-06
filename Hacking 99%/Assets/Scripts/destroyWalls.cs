using UnityEngine;
using System.Collections;

public class destroyWalls : MonoBehaviour {
    public GameObject explosao;
    public int wallLife = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(getVida() <= 0)
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D colisor)
   {
        if(colisor.gameObject.tag == "Tiro")
        {
            menosVida(1);
        }
    }
    public void menosVida(int vida)
    {
        wallLife -= vida;
    }

    public int getVida()
    {
        return wallLife;
    }
}

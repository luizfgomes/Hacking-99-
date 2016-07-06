using UnityEngine;
using System.Collections;

public class RadarColliderDamage : MonoBehaviour
{

    private Player script;

    // Use this for initialization
    void Awake()
    {
        script = GameObject.FindGameObjectWithTag("Player1").GetComponent<Player>() as Player;
    }


    //verificaçao caso o player estiver dentro do raio de procura do player
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            script.menosVida(5);
        }
    }
}
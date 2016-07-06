using UnityEngine;
using System.Collections;

public class RadarInim00F2 : MonoBehaviour
{

    private Inim00IAF2 script;

    // Use this for initialization
    void Awake()
    {
        script = (Inim00IAF2)GetComponentInParent(typeof(Inim00IAF2));
    }


    //verificaçao caso o player estiver dentro do raio de procura do player
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            script.lostPlayer = false;
            script.canFly = true;
            print("Sim");
        }
    }

    //verificaçao caso o player NAO estiver dentro do raio de procura do player
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            script.lostPlayer = true;
            script.canFly = true;
            print("Nao");
        }
    }
}
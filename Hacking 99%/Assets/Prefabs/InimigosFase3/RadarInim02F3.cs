using UnityEngine;
using System.Collections;

public class RadarInim02F3 : MonoBehaviour {

    private Inim02IAF3 script;

    // Use this for initialization
    void Awake()
    {
        script = (Inim02IAF3)GetComponentInParent(typeof(Inim02IAF3));
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

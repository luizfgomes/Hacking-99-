﻿using UnityEngine;
using System.Collections;

public class RadarInim03 : MonoBehaviour {

    private Inim03IA script;

    // Use this for initialization
    void Awake()
    {
        script = (Inim03IA)GetComponentInParent(typeof(Inim03IA));
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
            script.BackToHome();
            script.lostPlayer = true;
            script.canFly = true;
            print("Nao");
        }
    }
}
using UnityEngine;
using System.Collections;

public class RadarBug01 : MonoBehaviour
{

    private BugInstantiate script;
    // Use this for initialization
    void Start()
    {
        script = (BugInstantiate)GetComponentInParent(typeof(BugInstantiate));
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            script.InstanciaInimigos();
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player1")
        {
            script.CancelInvoke();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}


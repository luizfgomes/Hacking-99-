using UnityEngine;
using System.Collections;

public class BugInstantiate : MonoBehaviour
{

    public GameObject inim1Prefab;
    public Transform posicaoInim1;

    // Use this for initialization
    void Start()
    {
        Invoke("InstanciaInimigos", 1);
    }

    public void InstanciaInimigos()
    {
        Instantiate(inim1Prefab, posicaoInim1.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


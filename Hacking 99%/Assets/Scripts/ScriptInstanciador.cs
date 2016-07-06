using UnityEngine;
using System.Collections;

public class ScriptInstanciador : MonoBehaviour
{

    public GameObject playerPrefab;
    public Transform posicaoPlayer;

    // Use this for initialization
    void Start()
    {
        Invoke("InstanciaPlayer", 1);
        //Destroy (gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy (gameObject, 3);
    }
    public void InstanciaPlayer()
    {
        Instantiate(playerPrefab, posicaoPlayer.position, Quaternion.identity);
    }
}

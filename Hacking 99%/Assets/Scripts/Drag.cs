using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]

public class Drag : MonoBehaviour 
{
    public int mouseVisibility = 1;
    public Transform AnalogPrefab;
    bool analog;
    public LayerMask hit;

    // Update is called once per frame
    void Update () 
	{
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouseVisibility);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
		transform.position = curPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mouseVisibility == 1)
            {
                mouseVisibility = 0;
                Debug.Log("Invisível");
            }
            else
            {
                mouseVisibility = 1;
                Debug.Log("Visível");
            }
        }

        if(!analog)
        {
            analog = true;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.name == "Limite Esquerda")
        {
            Debug.Log("teta esquerda");
        }
        else if (colisor.gameObject.name == "Limite Direita")
        {
            Debug.Log("teta direita");
        }
        else if (colisor.gameObject.name == "Limite Baixo")
        {
            Debug.Log("xota");
        }
    }
}
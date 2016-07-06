using UnityEngine;
using System.Collections;

public class MoveTrailEnemy : MonoBehaviour {

    public int moveSpeed;


	void Start()
	{
		Vector3 tiroPos = GameObject.FindGameObjectWithTag("Player1").transform.position;
		transform.rotation = Quaternion.LookRotation(Vector3.forward, tiroPos - transform.position);
	}

    void Update()
    {	
		transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 2);
    }
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player1")
        {
            Destroy(gameObject);
        }
        if (colisor.gameObject.tag == "escudo")
        {
            Destroy(gameObject);
        }
		if (colisor.gameObject.tag == "paredes")
		{
			Destroy(gameObject);
		}
    }


    }

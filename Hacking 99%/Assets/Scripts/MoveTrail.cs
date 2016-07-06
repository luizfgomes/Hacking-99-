using UnityEngine;
using System.Collections;

public class MoveTrail : MonoBehaviour
{
    public static float moveSpeed = 10;

 
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 2);
	}

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Nucleo")
        {
            Destroy(gameObject);
			Debug.Log("acertou");
		}
		if (colisor.gameObject.tag == "nucleo01")
		{
			Destroy(gameObject);
			Debug.Log("acertou");
		}
      	if(colisor.gameObject.tag == "inimigo00")
        {
            Destroy(gameObject);
            Debug.Log("acertou");
        }
        if (colisor.gameObject.tag == "inimigo01")
        {
            Destroy(gameObject);
            Debug.Log("acertou");
        }
        if (colisor.gameObject.tag == "inimigo02")
        {
            Destroy(gameObject);
            Debug.Log("acertou");
        }
        if (colisor.gameObject.tag == "inimigo03")
        {
            Destroy(gameObject);
            Debug.Log("acertou");
        }
        if (colisor.gameObject.tag == "paredes")
        {
            Destroy(gameObject);
            Debug.Log("acertou");
        }
    }
}

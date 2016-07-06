using UnityEngine;
using System.Collections;

public class Portao : MonoBehaviour {

    public bool keyWall2;

    // Use this for initialization
    void Start()
    {
        
    }
            	
	// Update is called once per frame
	void Update () {
        keyWall2 = Player.keyWall;
    }
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player1")
        {
            if(keyWall2 == true)
                {
                    Destroy(gameObject);
                }
        }
    }
}

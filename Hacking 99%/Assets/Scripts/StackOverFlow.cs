using UnityEngine;
using System.Collections;

public class StackOverFlow : MonoBehaviour
{
    public Transform gameOver;

    bool gameOverScreen;
    float timeLeft = 180.0f;    
	
	// Update is called once per frame
	void Update ()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            if(!gameOverScreen)
            {
                Instantiate(gameOver, new Vector3(0.22f, -0.24f, 0), Quaternion.identity);
                gameOverScreen = true;
                Time.timeScale = 0;
            }
        }
    }
}
using UnityEngine;
using System.Collections;

public class game_quit : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.Quit();
            Debug.Log("quit");
        }
	}
}

using UnityEngine;
using System.Collections;

public class sound_switch : MonoBehaviour
{
    bool soundSwitch = true;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (soundSwitch)
            {
                AudioListener.volume = 1;
                soundSwitch = false;
                Debug.Log("liga");
            }
            else
            {
                AudioListener.volume = 0;
                soundSwitch = true;
                Debug.Log("desliga");
            }
        }
    }
}
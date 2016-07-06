using UnityEngine;
using System.Collections;

public class SoundEffectScript : MonoBehaviour {

	public static SoundEffectScript Instance;

	public AudioClip ColetaSound;

	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Existem múltiplas instâncias do script SoundEffectScript.");
		}

		Instance = this;
	}
	public void MakeColetaSound()
	{
		MakeSound (ColetaSound);
	}

	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}

using UnityEngine;
using System.Collections;

public class movimentarCArcade: MonoBehaviour {
	
	public Transform pt;
	public Transform ct;
	// Update is called once per frame
	void Update () {
		Vector3 posicaoDaCamera = pt.position;

		if (pt.position.x >= -13.77f && pt.position.x <= 13.75f) {
			posicaoDaCamera.x = pt.position.x;
		} else {

			if (pt.position.x > 0) {
				posicaoDaCamera.x = 13.75f;
			} else { 
				posicaoDaCamera.x = -13.77f;
			}
		}
		if (pt.position.y >= -10.0f && pt.position.y <= 10.0f) {
			posicaoDaCamera.y = pt.position.y;
		} else {
			
			if (pt.position.y > 0) {
				posicaoDaCamera.y = 10.0f;
			} else { 
				posicaoDaCamera.y = -10.0f;
			}
		}

		posicaoDaCamera.z = -12f;
		ct.position = posicaoDaCamera;

//		if (pt.position.x >= -13.77f && pt.position.x <= 13.75f && pt.position.y <= 10.0f && pt.position.y>= -10.0f) {
//
//			if (pt.position.x == -13.77){
//				ct.position = Vector3.Lerp (ct.position, new Vector3 (-13.77f, pt.position.y, ct.position.z), 2.3f);
//			} else {
//				ct.position = Vector3.Lerp (ct.position, new Vector3 (pt.position.x, pt.position.y, ct.position.z), 2.3f);
//			}
//
//		}
	}
}
using UnityEngine;
using System.Collections;

public class movimentarCF2 : MonoBehaviour {

    public Transform pt;
    public Transform ct;
    // Update is called once per frame
    void Update()
    {
        Vector3 posicaoDaCamera = pt.position;

        if (pt.position.x >= -33.94f && pt.position.x <= 33.94f)
        {
            posicaoDaCamera.x = pt.position.x;
        }
        else {

            if (pt.position.x > 0)
            {
                posicaoDaCamera.x = 33.94f;
            }
            else {
                posicaoDaCamera.x = -33.94f;
            }
        }
        if (pt.position.y >= -25.2f && pt.position.y <= 25.2f)
        {
            posicaoDaCamera.y = pt.position.y;
        }
        else {

            if (pt.position.y > 0)
            {
                posicaoDaCamera.y = 25.2f;
            }
            else {
                posicaoDaCamera.y = -25.2f;
            }
        }

        posicaoDaCamera.z = -12f;
        ct.position = posicaoDaCamera;
    }
}

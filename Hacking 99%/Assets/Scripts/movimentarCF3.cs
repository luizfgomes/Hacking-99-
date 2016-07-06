using UnityEngine;
using System.Collections;

public class movimentarCF3 : MonoBehaviour
{
    public Transform pt;
    public Transform ct;
    // Update is called once per frame
    void Update()
    {
        Vector3 posicaoDaCamera = pt.position;

        if (pt.position.x >= -41.24f && pt.position.x <= 41.19f)
        {
            posicaoDaCamera.x = pt.position.x;
        }
        else {

            if (pt.position.x > 0)
            {
				posicaoDaCamera.x = 41.19f;
            }
            else {
                posicaoDaCamera.x = -41.24f;
            }
        }
        if (pt.position.y >= -30.6f && pt.position.y <= 30.56f)
        {
            posicaoDaCamera.y = pt.position.y;
        }
        else {

            if (pt.position.y > 0)
            {
				posicaoDaCamera.y = 30.56f;
            }
            else {
                posicaoDaCamera.y = -30.6f;
            }
        }

        posicaoDaCamera.z = -12f;
        ct.position = posicaoDaCamera;
    }
}

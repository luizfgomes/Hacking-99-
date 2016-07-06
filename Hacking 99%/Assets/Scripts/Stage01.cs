using UnityEngine;
using System.Collections;

public class Stage01 : MonoBehaviour
{
    public Transform PausarAsset;
    public Transform InstrucoesAsset;
    public Transform SairAsset;

    int selectionMenu = 0;

    bool CanPause = true;
    bool notOver;
    bool pauseInstance;
    bool instrucoesInstance;
    bool sairInstance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (CanPause)
            {
                Time.timeScale = 0;
                CanPause = false;
                selectionMenu = 0;
                Debug.Log("Paused");
                notOver = true;
            }
            else
            {
                Time.timeScale = 1;
                CanPause = true;
                Debug.Log("Playing");
                notOver = false;
                if (pauseInstance)
                {
                    //Destroy(PausarAsset, 3.0f);
                    DestroyImmediate(PausarAsset, true);
                    //DestroyObject(PausarAsset);
                }
                if (sairInstance)
                {
                    //Destroy(SairAsset, 3.0f);
                    DestroyImmediate(SairAsset, true);
                    //DestroyObject(SairAsset);
                }
                if (instrucoesInstance)
                {
                    //Destroy(InstrucoesAsset, 3.0f);
                    DestroyImmediate(InstrucoesAsset, true);
                    //DestroyObject(InstrucoesAsset);
                }
                pauseInstance = false;
                instrucoesInstance = false;
                sairInstance = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            selectionMenu--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            selectionMenu++;
        }

        if (Time.timeScale == 0 && notOver)
        {
            if(selectionMenu == 0 && !pauseInstance)
            {
                Instantiate(PausarAsset, new Vector3(-7.134f, 4.728f, 0), Quaternion.identity);
                pauseInstance = true;
                if(sairInstance)
                {
                    //Destroy(SairAsset, 3.0f);
                    DestroyImmediate(SairAsset, true);
                    //DestroyObject(SairAsset);
                }
                sairInstance = false;
                if(instrucoesInstance)
                {
                    //Destroy(InstrucoesAsset, 3.0f);
                    DestroyImmediate(InstrucoesAsset, true);
                    //DestroyObject(InstrucoesAsset);
                }
                instrucoesInstance = false;
            }

            else if (selectionMenu == 1 && !instrucoesInstance)
            {
                Instantiate(InstrucoesAsset, new Vector3(-4.907f, 4.728f, 0), Quaternion.identity);
                instrucoesInstance = true;
                if(pauseInstance)
                {
                    //Destroy(PausarAsset, 3.0f);
                    DestroyImmediate(PausarAsset, true);
                    //DestroyObject(PausarAsset);
                }
                pauseInstance = false;
                if (sairInstance)
                {
                    //Destroy(SairAsset, 3.0f);
                    DestroyImmediate(SairAsset, true);
                    //DestroyObject(SairAsset);
                }
                sairInstance = false;
            }

            else if (selectionMenu == 2 && !sairInstance)
            {
                Instantiate(SairAsset, new Vector3(-2.642f, 4.728f, 0), Quaternion.identity);
                sairInstance = true;
                if (instrucoesInstance)
                {
                    //Destroy(InstrucoesAsset, 3.0f);
                    DestroyImmediate(InstrucoesAsset, true);
                    //DestroyObject(InstrucoesAsset);
                }
                instrucoesInstance = false;
                if (pauseInstance)
                {
                    //Destroy(PausarAsset, 3.0f);
                    DestroyImmediate(PausarAsset, true);
                    //DestroyObject(PausarAsset);
                }
                pauseInstance = false;
            }
            else if (selectionMenu > 2)
            {
                selectionMenu = 0;
            }
            else if (selectionMenu < 0)
            {
                selectionMenu = 2;
            }
        }
    }
}
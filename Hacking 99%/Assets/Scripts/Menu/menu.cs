using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	private float selectMenu = 0;
	private float selectFase = 0;
	private float selectHorizontal = 0;
	private float verticalSpeed = 0.86f;
	private float horizontalSpeed = 1.8f;
	private float selectOption = 1.0f;
	public GameObject voltar;
	public GameObject voltarSelcao;
	public GameObject instrucoes;
	public GameObject creditos;
	public GameObject fase_1;
	public GameObject fase_2;
	public GameObject fase_3;
	public GameObject somOn;
	public GameObject somOff;
	public GameObject exit;
	private bool entrou= true;
	private bool audioTocar = true;
	public GameObject bug1;
	public GameObject bug2;
	public GameObject bug3;
	private float quitGame=1.0f;
	public static bool fase2ok = false;
	public static bool fase3ok = false;
	public static bool arcadeok = false;

    static public bool soundEnter;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("up")) {
			if (selectMenu>=1 && selectOption==1){
				selectMenu=selectMenu-1;
				print(selectMenu);
				transform.Translate(Vector3.up * verticalSpeed);
			}
			if (selectMenu>=1 && selectOption==3){
				selectMenu=selectMenu-1;
				print(selectMenu);
				transform.Translate(Vector3.up * verticalSpeed);
				selectFase=selectFase-1;
			}
			if (selectMenu>=1 && selectOption==4){
				selectMenu=selectMenu-1;
				print(selectMenu);
				transform.Translate(Vector3.up * verticalSpeed);
				selectFase=selectFase-1;
			}
		} 
		if (Input.GetKeyUp("down")) {
			if (selectMenu<=3 && selectOption==1 ){
				selectMenu=selectMenu+1;
				print(selectMenu);
				transform.Translate(Vector3.down * verticalSpeed);
			}else if (selectMenu<=0 && selectOption==4 ){
				selectMenu=selectMenu+1;
				print(selectMenu);
				transform.Translate(Vector3.down * verticalSpeed);
				selectFase=selectFase+1;
			} else 	if ( arcadeok==true){
				if (selectMenu<=2 && selectOption==3 ){
					selectMenu=selectMenu+1;
					print(selectMenu);
					transform.Translate(Vector3.down * verticalSpeed);
					selectFase=selectFase+1;
				}
			}else if ( fase3ok==true){
				if (selectMenu<=1 && selectOption==3 ){
					selectMenu=selectMenu+1;
					print(selectMenu);
					transform.Translate(Vector3.down * verticalSpeed);
					selectFase=selectFase+1;
				}
			} else if ( fase2ok==true){
				if (selectMenu<=0 && selectOption==3 ){
					selectMenu=selectMenu+1;
					transform.Translate(Vector3.down * verticalSpeed);
					selectFase=selectFase+1;
				}
			} 
		}

		if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp ("enter")) {

			if (selectOption == 3 && selectMenu ==0 )
			{
				Application.LoadLevel("CS1");
			} else if (selectOption == 3 && selectMenu ==1 )
			{
				Application.LoadLevel("CS2");
			} else if (selectOption == 3 && selectMenu == 2 )
			{
				Application.LoadLevel("CS3");
			} else if (selectOption == 3 && selectMenu ==3 )
			{
				Application.LoadLevel("arcade");
			}


			if (selectOption == 2 && selectHorizontal ==0 && audioTocar==false){
				audioTocar = true;
			}
			if (selectOption == 2 && selectHorizontal ==1 && audioTocar==true ){
				audioTocar = false;
			}
			if (selectMenu==0 && selectOption==1){
				transform.position = new Vector3(1.6f,2.465f,0);
				selectOption=selectOption+2;
				Instantiate(fase_1,new Vector3(0,0, 0),Quaternion.identity);
				if (arcadeok == false){
					Instantiate(bug1, new Vector3(2.5f,-0.2f,-1),Quaternion.identity);
				}
				if (fase3ok == false){
					Instantiate(bug2, new Vector3(2.5f,0.7f,-1),Quaternion.identity);
				}
				if (fase2ok == false){
					Instantiate(bug2, new Vector3(2.5f,1.6f,-1),Quaternion.identity);
				}
            }
			if (selectMenu==1 && selectOption==1){
				transform.position = new Vector3(1.7f,2.33f,0);
				selectOption=selectOption+4;
				Instantiate(somOn,new Vector3(0f,0f, 0),Quaternion.identity);
                soundEnter = true;
            }
			if (selectMenu==2 && selectOption==1){
				transform.position = new Vector3(-1.7f,-4.2f,0);
				selectOption=selectOption+1;
				Instantiate(instrucoes,new Vector3(0,0, 0),Quaternion.identity); 

			}
			if (selectMenu==3 && selectOption==1){
				transform.position = new Vector3(-1.0f,-4.15f,0);
				selectOption=selectOption+1;
				Instantiate(creditos,new Vector3(0,0,0),Quaternion.identity);
			}
			if(selectMenu==4 && selectOption==1 && entrou == true){
				transform.position = new Vector3(1.8f,2.465f,0);
				selectOption=selectOption+3;
				Instantiate(exit,new Vector3(0,0,0),Quaternion.identity);
				selectMenu=0;
				entrou = false;
			}
			if (selectMenu==1 && selectOption==4 && entrou == false ){
				transform.position = new Vector3(-5.64f,-0.1f,0);
				selectOption=selectOption-3;
				//Instantiate(exit,new Vector3(0,0,0),Quaternion.identity);
				selectMenu=4;
				entrou = true;
			} else if (selectMenu==0 && selectOption==4 ){
				quitGame++;
			}

			if (quitGame == 3){
				Application.Quit();
				print ("QUIT");
			}

			
		}

		if (Input.GetKeyDown ("escape")) {

			if (selectMenu>=0 && selectOption==3){
				transform.position = new Vector3(-5.64f,3.34f,0);
				selectOption=selectOption-2;
				selectMenu=0;
			}

			if (selectMenu==1 && selectOption==5){
				transform.position = new Vector3(-5.64f,2.51f,0);
				selectOption=selectOption-4;
				selectMenu=1;
			}
			if (selectMenu==2 && selectOption==2){
				transform.position = new Vector3(-5.64f,1.68f,0);
				selectOption=selectOption-1;
				selectMenu=2;
			}
			if (selectMenu==3 && selectOption==2){
				transform.position = new Vector3(-5.64f,0.85f,0);
				selectOption=selectOption-1;
				selectMenu=3;
			}
			if (selectMenu>=0 && selectOption==4){
				transform.position = new Vector3(-5.64f,-0.1f,0);
				selectOption=selectOption-3;
				selectMenu=4;
			}
		}
		
		if (Input.GetKeyDown("right") ){
			if (selectOption==5 && selectHorizontal==0){
				transform.Translate(Vector3.right * horizontalSpeed);
				selectHorizontal++;
			}
		}
		if (Input.GetKeyDown("left") ){
			if (selectOption==5 && selectHorizontal==1){
				transform.Translate(Vector3.left * horizontalSpeed);
				selectHorizontal--;
			}
		}
	}
}

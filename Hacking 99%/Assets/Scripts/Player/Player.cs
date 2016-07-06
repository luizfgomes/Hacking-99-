using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Text pontosText;
	public Text RecordText;
	public Text arcadeText;
    public float maxSpeed;
    public LayerMask hit;
    public GameObject explosao;
    Animator anim;
    float timerPower = 15f;
    public static int playerLife = 100;
    public static bool keyWall;
    bool danoPowerSpeed = false;
	public static float positionPlayerX;
	public static float positionPlayerY;
	public static float pontuacaoGame = 0;
	public static float pontuacaoArcade = 0;
	public static float pontuacaoRecord = 0;
	public static float pontuacaoTop = 0;

    bool pause = false;

    // Use this for initialization
    void Start()
    {
		playerLife = 100;
        anim = GetComponent<Animator> ();
		RecordText.text = "RECORD: " + pontuacaoRecord.ToString ();
    }
	void InstanciaExplosao()
	{
		Instantiate(explosao, transform.position, Quaternion.identity);
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "colliderDamage")
        {
            if (danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
            }
            anim.SetBool("levouDano", true);
        }
    }

	void OnCollisionEnter2D(Collision2D colisor)
	{
        
		if (colisor.gameObject.tag == "powerDefesa")
		{
			timerPower = 15f;
			anim.SetBool("perdeupower", false);
            //anim.SetBool("powerup2", true);
            anim.SetBool("powerup3", false);
        }
        if (colisor.gameObject.tag == "powerSpeed")
        {
			maxSpeed = 10f;
			MoveTrail.moveSpeed = 14.5f;
			timerPower = 15f;
            danoPowerSpeed = true;
			anim.SetBool("perdeupower", false);
            anim.SetBool("powerup2", false);
            anim.SetBool("powerup3", true);
            
        }
        if (colisor.gameObject.tag == "powerVida")
        {
            playerLife += 50;
        }

        if (colisor.gameObject.tag == "tiroInimigo")
        {
            anim.SetBool("levouDano", true);
            menosVida(5);
            if(danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
                menosVida(5);
            }
        }
        if (colisor.gameObject.tag == "inimigo00")
        {
            anim.SetBool("levouDano", true);
            menosVida(5);
            if (danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
                menosVida(5);
            }
        }
        if (colisor.gameObject.tag == "inimigo01")
        {
            anim.SetBool("levouDano", true);
            menosVida(5);
            if (danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
                menosVida(5);
            }
        }
        if (colisor.gameObject.tag == "inimigo02")
        {
            anim.SetBool("levouDano", true);
            menosVida(5);
            if (danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
                menosVida(5);
            }
        }
        if (colisor.gameObject.tag == "inimigo03")
        {
            anim.SetBool("levouDano", true);
            menosVida(5);
            if (danoPowerSpeed == true)
            {
                anim.SetBool("levouDano2", true);
                menosVida(5);
            }
        }

    }
    public void levouDano()
    {
        anim.SetBool("levouDano", false);     
    }
    public void levouDano2()
    {
        anim.SetBool("levouDano2", false);
    }

    public void menosVida(int vida)
    {
        playerLife -= vida;
    }

    public int getVida()
    {
        return playerLife;
    }

    void Update()
	{
        if (pontosText) {
			pontosText.text = "SCORE: " + pontuacaoGame.ToString ();
		} else {
			arcadeText.text = "SCORE: " + pontuacaoArcade.ToString ();
		}

        timerPower -= Time.deltaTime;
        if (timerPower < 0)
        {
            maxSpeed = 5f;
            anim.SetBool("powerup2", false);
			anim.SetBool("powerup3", false);
            anim.SetBool("perdeupower", true);
        }

        if (getVida() <= 0)
        {
            Invoke("InstanciaExplosao", 1);
            // Criando o som da explosão.
            Destroy(gameObject);
        }        
    }

    // Update is called once per frame
    void FixedUpdate () 
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveY * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * maxSpeed, GetComponent<Rigidbody2D>().velocity.x);

		
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }
}
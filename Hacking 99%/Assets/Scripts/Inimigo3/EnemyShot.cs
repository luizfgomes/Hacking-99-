using UnityEngine;
using System.Collections;

public class EnemyShot : MonoBehaviour {

    public float Damage = 10;

    public Transform enemyBullet;
    public float effectSpawnRate = 10;
	public float shootCooldown;
	public float shootIntRate = 0.75f;

	Transform firePoint;

	void Awake ()
	{
		firePoint = transform.FindChild("FirePoint");
		
		if (firePoint == null)
		{
			Debug.LogError("No fire point? WUT?");
		}
	}
	void Start()
	{
		shootCooldown = 0;
	}

	public void Update()
	{

		//Attack ();
		if (shootCooldown >= 0) {
			shootCooldown -= Time.deltaTime;
            Debug.Log("Shot");
		}
	}

    public void Attack()
    {
		if (shootCooldown <= 0) {
			Debug.Log("Entrou");

			shootCooldown = shootIntRate;
			var shotTransform = Instantiate(enemyBullet) as Transform;
			shotTransform.position = firePoint.position;
		}
    }
}


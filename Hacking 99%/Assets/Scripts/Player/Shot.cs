﻿using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
    public float fireRate = 0;
    public float Damage = 10;
    public LayerMask Hit;

    public Transform BulletTrailPrefab;
    float timeToSpawnEffect = 0;
    public float effectSpawnRate = 10;

    float timeToFire = 0;
    Transform firePoint;

	// Use this for initialization
	void Awake ()
    {
        firePoint = transform.FindChild("FirePoint");
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (fireRate == 0)
        {
            if(Input.GetButtonUp("Fire1"))
            {
                Shoot();
            }
        }
        else
        {
            if(Input.GetButtonUp("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition-firePointPosition, 100);
        if(Time.time >= timeToSpawnEffect)
        {
            Effect();
            timeToSpawnEffect = Time.time + 1 / effectSpawnRate; 
        }
    }

    void Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);
    }
}

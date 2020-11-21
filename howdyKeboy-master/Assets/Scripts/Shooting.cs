﻿using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class Shooting : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;
	public CameraShake camera;
	public float bulletForce = 10f;
    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1")){
			Shoot();
		}
    }
	void Shoot(){
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position,firePoint.rotation);
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
		rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
		StartCoroutine(camera.Shake(.1f,.1f));
	}
	//naber baptın


}

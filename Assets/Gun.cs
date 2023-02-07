using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Transform bulletSpawnPoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float shootingForce = 30f;

    // Update is called once per frame
    void Update()
    {
        ShootGun();
    }

    private void ShootGun()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
            //bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.right * bulletSpeed);
        }
    }
}

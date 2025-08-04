using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    private Inventory inven;
    void Awake()
    {
        inven = GetComponent<Inventory>();
    }
    void Shoot()
    {
        if (Input.GetButtonDown("Fire1")
            && inven.myStuff.bullets > 0)
        {
            Rigidbody bullet = Instantiate(
                bulletPrefab,
                firePosition.position,
                firePosition.rotation
                ) as Rigidbody;
            bullet.AddForce(
                firePosition.forward * bulletSpeed);
            inven.myStuff.bullets--;
        }
    }
    void Update()
    {
        Shoot();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject shootingPoint;
    public GameObject Bullet;
    public Camera cam;
    public float BulletSpeed;
    public float shootingSpeed;
    private float nextTimeToFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / shootingSpeed;
            Shoot();
        }
    }


    void Shoot() 
    {
        GameObject ShotBullet = Instantiate(Bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        ShotBullet.GetComponent<Bullet>().BulletSpeed = BulletSpeed;
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 startPos = transform.position;
        ShotBullet.GetComponent<Rigidbody2D>().AddForce((mousePos - startPos) * BulletSpeed);
    }
}

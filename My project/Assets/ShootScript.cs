using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform Gun;

    Vector2 direction;

    public GameObject Bullet;

    public Transform ShootPoint;

    public float BulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();

        if(Input.getmouseButtonDown(0))
        {
            shoot();
        }
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }
    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet,ShootPoint.position,shootPoint.rotation);
    BulletIns.GetComponent<Ridgidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
    }
}


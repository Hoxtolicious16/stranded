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

        if(Input.GetMouseButtonDown(0))
        {
            shoot();
            if (collisionInfo.collider.tag == "Gegener")
                Destroy(collisionInfo.GameObject, 5f);
        }
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }
    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet,ShootPoint.position,ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
    
    }
}


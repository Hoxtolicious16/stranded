using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gegner : MonoBehaviour
{
    public Transform Spieler;
    public float speed;
    private Vector3 Ziel;
    private float ZielUpdate;
    public float ZielUpdateDelay = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>ZielUpdate)
        {
            Ziel = Spieler.position;
            ZielUpdate = Time.time + ZielUpdateDelay;
        }
        
       var direction = (Ziel - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}

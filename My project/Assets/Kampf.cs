using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kampf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Player")
        {
            var HUD = col.gameObject.GetComponent<SteuerHerz>();
            Debug.Log("DAmage");
            HUD.takeDamage();
        }
        if(col.gameObject.name=="BulletObject")
        {
            Destroy(gameObject);
        }
    }
}

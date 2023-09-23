using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kampf : MonoBehaviour
{
    private bool isPlayerInRange=false;
    public GameObject Spieler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInRange)
        {
            var HUD = Spieler.GetComponent<Inventar>();
            HUD.takeDamage();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enter");
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=true;
            Spieler = col.gameObject;
        }
        if(col.gameObject.name=="BulletObject")
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exit");
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=false;
            Spieler = null;
        }
    }
}

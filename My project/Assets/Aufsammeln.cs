using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aufsammeln : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPlayerInRange=false;
    public GameObject Spieler;
    void Update()
    {
        if(isPlayerInRange&&Input.GetButtonDown("Fire1"))
        {
            var Inventar = Spieler.GetComponent<Inventar>();
            if (Inventar!=null)
            {
                Inventar.addReparaturTeil();
                Destroy(gameObject);
            }
            
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

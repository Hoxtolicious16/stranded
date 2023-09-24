using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Aufsammeln : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ReparaturTeil;
    private bool isPlayerInRange=false;
    GameObject rT= null;//Fehler
    void Start(){}
    public GameObject Spieler;
    void Update()
    {
        if(isPlayerInRange&&Input.GetButtonDown("Fire1"))
        {
            rT=gameObject; //Fehler
            Destroy(gameObject);
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
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=true;
            Spieler = col.gameObject;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=false;
            Spieler = null;
        }
    }
}

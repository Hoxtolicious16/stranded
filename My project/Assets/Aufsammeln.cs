using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aufsammeln : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ReparaturTeil;
    private bool isPlayerInRange=false;
    GameObject rT= null;//Fehler
    void Start()
    {
        if(isPlayerInRange&&Input.GetButtonDown("Fire1"))
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enter");
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exit");
        if(col.gameObject.name=="Spieler")
        {
            isPlayerInRange=false;
        }
    }
}

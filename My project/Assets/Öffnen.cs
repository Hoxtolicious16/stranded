using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Öffnen : MonoBehaviour
{
    public GameObject ReparaturTeil;
    private bool isPlayerInRange=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInRange&&Input.GetButtonDown("Fire1"))
        {
            GameObject teil=Instantiate(ReparaturTeil,transform.position,transform.rotation);
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

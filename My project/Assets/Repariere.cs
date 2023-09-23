using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Repariere : MonoBehaviour
{
    private bool isPlayerInRange=false;
    public GameObject Spieler;
    public int fortschritt;
    public Text textfield1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInRange&&Input.GetButtonDown("Fire1"))
        {
            var Inventar = Spieler.GetComponent<Inventar>();
            if (Inventar!=null)
            {
                Inventar.removeReparaturTeil();
                if(fortschritt<3)
                {
                    fortschritt++;
                }
            }
            
        }
        textfield1.text=fortschritt.ToString();
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

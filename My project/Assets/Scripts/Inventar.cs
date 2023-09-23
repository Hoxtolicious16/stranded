using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
    public int anzahlReparatur=0;
    public Text textfield;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textfield.text=anzahlReparatur.ToString();
    }
    public void addReparaturTeil()
    {
        anzahlReparatur++;
    }
    public void removeReparaturTeil()
    {
        if(anzahlReparatur>0)
        {
            anzahlReparatur--;
        }
    }
    public int gibAnzahl()
    {
        return anzahlReparatur;
    }
    public void takeDamage()
    {
        
    }
}

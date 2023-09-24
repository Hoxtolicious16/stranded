using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventar : MonoBehaviour
{
    public int anzahlReparatur=0;

    public int anzahlBeeren =0;
    public Text textfieldB;
    public Text textfieldR;
    public GameObject Herzen;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        textfieldR.text=anzahlReparatur.ToString();
        //textfieldB.text=anzahlBeeren.ToString();
    }
    public void addReparaturTeil()
    {
        Debug.Log("add");
        anzahlReparatur++;
    }
    public void removeReparaturTeil()
    {
        if(anzahlReparatur>0)
        {
            anzahlReparatur--;
        }
    }
    public void addBeeren()
    {
        anzahlBeeren++;
    }
    public void removeBeeren()
    {
        if(anzahlBeeren>0)
        {
            anzahlBeeren--;
        }
    }
    public int gibAnzahlR()
    {
        return anzahlReparatur;
    }
    public int gibAnzahlB()
    {
        return anzahlBeeren;
    }
}

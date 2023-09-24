using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aufsammeln : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private int beerenGesammelt = 0; // Anzahl der gesammelten Beeren
    public int maxBeeren = 3; // Maximale Anzahl der aufsammelbaren Beeren
    public GameObject Spieler;

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1") && beerenGesammelt < maxBeeren)
        {
            var Inventar = Spieler.GetComponent<Inventar>();
            if (Inventar != null)
            {
                Inventar.addBeere();
                beerenGesammelt++;

                if (beerenGesammelt >= maxBeeren)
                {
                    Debug.Log("Maximale Anzahl an Beeren erreicht: " + maxBeeren);
                    // Weitere Aktionen, wenn die maximale Anzahl erreicht wurde.
                }
            }
        }

        // Wenn "R" gedrückt wird und die maximale Anzahl Beeren erreicht ist, setze die Variable auf drei.
        if (Input.GetKeyDown(KeyCode.R) && beerenGesammelt == maxBeeren)
        {
            Debug.Log("Variable auf " + maxBeeren + " setzen.");
            beerenGesammelt = maxBeeren;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Enter");
        if (col.gameObject.name == "Spieler")
        {
            isPlayerInRange = true;
            Spieler = col.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exit");
        if (col.gameObject.name == "Spieler")
        {
            isPlayerInRange = false;
            Spieler = null;
        }
    }
}

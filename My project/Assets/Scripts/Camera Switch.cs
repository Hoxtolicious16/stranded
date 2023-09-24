using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera gamera;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Spieler")
        {
            Debug.Log($"Switch camera {gamera.name}");
            Camera.main.enabled = false;
            gamera.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

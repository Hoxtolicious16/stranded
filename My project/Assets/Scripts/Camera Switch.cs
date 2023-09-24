using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Spieler")
        {
            Debug.Log($"Switch camera {camera.name}");
            Camera.main.enabled = false;
            camera.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

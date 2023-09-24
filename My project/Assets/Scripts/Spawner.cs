using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public int begrenzer = 15;
    [SerializeField]
    private GameObject enemy;

    public Transform Spieler;

    [SerializeField]
    private float interval = 3f;
    private float nextSpawn = 0;
    void Update()
    {
        if (begrenzer>0&&Time.time > nextSpawn)
        {
            begrenzer--;
            nextSpawn = Time.time + interval;
            GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
            newEnemy.GetComponent<Gegner>().Spieler = Spieler;
        }
    }
}

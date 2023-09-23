using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen : MonoBehaviour
{
    public float moveSpeed;  // Korrekte Schreibweise der Variablen
    public float isMoving;

    public Vector2 input;

    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input != Vector2.zero)  // Korrekte Verwendung von Vector2.zero
            {
                var targetPos = transform.position;  // Umbenennung der Variable
                targetPos.x += input.x;
                targetPos.y += input.y;

                StartCoroutine(Move(targetPos));  // Korrekter Aufruf der Move-Methode
            }
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)  // Korrekte Verwendung von Mathf.Epsilon
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }
}

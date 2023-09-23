using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen1 : MonoBehaviour
{
    public float moveSpeed;
    public float isMoving;

    private Vector2 input;  // Änderung: input als Vector2

    private void Update()
    {
        if (isMoving == 0)  // Änderung: Vergleichsoperator angepasst
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input.magnitude > 0)  // Änderung: Prüfen, ob Eingaben vorhanden sind
            {
                var targetPos = transform.position;  // Änderung: Variable als Vector2
                targetPos.x += input.x;
                targetPos.y += input.y;

                StartCoroutine(Move(targetPos));
            }
        }
    }

    IEnumerator Move(Vector2 targetPos)  // Änderung: Parameter als Vector2
    {
        isMoving = 1;  // Änderung: Wert als float gesetzt

        while ((targetPos - (Vector2)transform.position).sqrMagnitude > Mathf.Epsilon)  // Änderung: Vector2 und sqrMagnitude korrekt verwendet
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);  // Änderung: Vector2.MoveTowards verwendet
            yield return null;
        }
        transform.position = targetPos;

        isMoving = 0;  // Änderung: Wert als float gesetzt
    }
}

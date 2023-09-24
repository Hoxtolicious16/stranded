using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen : MonoBehaviour
{
<<<<<<< Updated upstream:My project/Assets/Scripts/Bewegen.cs
    public Animator animator;
    Rigidbody2D body;
=======
    public float moveSpeed;
    public float isMoving;
>>>>>>> Stashed changes:My project/Assets/Bewegen.cs

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
<<<<<<< Updated upstream:My project/Assets/Scripts/Bewegen.cs
    // Gives a value between -1 and 1
    horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
    vertical = Input.GetAxisRaw("Vertical"); // -1 is down
        Animate();
    }
=======
        isMoving = 1;  // Änderung: Wert als float gesetzt
>>>>>>> Stashed changes:My project/Assets/Bewegen.cs

        while ((targetPos - (Vector2)transform.position).sqrMagnitude > Mathf.Epsilon)  // Änderung: Vector2 und sqrMagnitude korrekt verwendet
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);  // Änderung: Vector2.MoveTowards verwendet
            yield return null;
        }
        transform.position = targetPos;

        isMoving = 0;  // Änderung: Wert als float gesetzt
    }
    void Animate()
    {
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", runSpeed);
    }
}

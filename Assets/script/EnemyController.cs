using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // R�f�rence au joueur � suivre
    public float followDistance = 5f; // Distance � laquelle les ennemis commencent � suivre le joueur
    public float moveSpeed = 3f; // Vitesse de d�placement des ennemis

    private Animator animator; // R�f�rence � l'animator
    private Rigidbody2D rb; // R�f�rence au Rigidbody2D

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtenez la r�f�rence de l'animator
        rb = GetComponent<Rigidbody2D>(); // Obtenez la r�f�rence du Rigidbody2D
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player reference is missing!");
            return;
        }

        // V�rifiez la distance entre l'ennemi et le joueur
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Si la distance est inf�rieure � la distance de suivi
        if (distanceToPlayer <= followDistance)
        {
            // Calculez la direction vers laquelle se d�placer (vers le joueur)
            Vector3 moveDirection = (player.position - transform.position).normalized;

            // Mettez � jour les param�tres d'animation en fonction de la direction de d�placement
            UpdateAnimation(moveDirection);

            // D�placez l'ennemi dans cette direction avec une vitesse fixe
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
        }
    }

    void UpdateAnimation(Vector3 moveDirection)
    {
        float angle = Vector3.SignedAngle(Vector3.up, moveDirection, Vector3.forward);

        if (angle > -45 && angle <= 45)
        {
            animator.Play("enemieanim");
        }
        else if (angle > 45 && angle <= 135)
        {
            animator.Play("enemieGA");
        }
        else if (angle > 135 || angle <= -135)
        {
            animator.Play("enemieAR");
        }
        else if (angle > -135 && angle <= -45)
        {
            animator.Play("enemieDR");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si l'ennemi entre en collision avec un objet portant le tag "Obstacle"
        if (collision.collider.CompareTag("Obstacle"))
        {
            // Ne rien faire - l'ennemi ne traversera pas l'obstacle
        }
    }
}

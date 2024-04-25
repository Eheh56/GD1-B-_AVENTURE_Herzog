using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Référence au joueur à suivre
    public float followDistance = 5f; // Distance à laquelle les ennemis commencent à suivre le joueur
    public float moveSpeed = 3f; // Vitesse de déplacement des ennemis

    private Animator animator; // Référence à l'animator
    private Rigidbody2D rb; // Référence au Rigidbody2D

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtenez la référence de l'animator
        rb = GetComponent<Rigidbody2D>(); // Obtenez la référence du Rigidbody2D
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player reference is missing!");
            return;
        }

        // Vérifiez la distance entre l'ennemi et le joueur
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Si la distance est inférieure à la distance de suivi
        if (distanceToPlayer <= followDistance)
        {
            // Calculez la direction vers laquelle se déplacer (vers le joueur)
            Vector3 moveDirection = (player.position - transform.position).normalized;

            // Mettez à jour les paramètres d'animation en fonction de la direction de déplacement
            UpdateAnimation(moveDirection);

            // Déplacez l'ennemi dans cette direction avec une vitesse fixe
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

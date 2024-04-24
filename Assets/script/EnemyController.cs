using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Référence au joueur à suivre
    public float followDistance = 5f; // Distance à laquelle les ennemis commencent à suivre le joueur
    public float moveSpeed = 3f; // Vitesse de déplacement des ennemis

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

            // Déplacez l'ennemi dans cette direction avec une vitesse fixe
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }
}

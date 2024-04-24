using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // R�f�rence au joueur � suivre
    public float followDistance = 5f; // Distance � laquelle les ennemis commencent � suivre le joueur
    public float moveSpeed = 3f; // Vitesse de d�placement des ennemis

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

            // D�placez l'ennemi dans cette direction avec une vitesse fixe
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }
}

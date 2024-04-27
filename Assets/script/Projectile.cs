using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damageAmount = 1; // Montant de d�g�ts inflig�s � l'ennemi

    private void OnTriggerEnter(Collider other)
    {
        // Obtenez le composant Enemy de l'ennemi touch�
        Enemy enemy = other.GetComponent(Enemy);
        // Si l'ennemi est valide, infligez-lui des d�g�ts
        if (enemy != null)
        {
            enemy.TakeDamage(damageAmount);
        }

        // D�truisez le projectile apr�s avoir touch� l'ennemi
        Destroy(gameObject);
    }
}
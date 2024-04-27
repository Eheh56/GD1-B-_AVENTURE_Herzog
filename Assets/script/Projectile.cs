using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damageAmount = 1; // Montant de dégâts infligés à l'ennemi

    private void OnTriggerEnter(Collider other)
    {
        // Obtenez le composant Enemy de l'ennemi touché
        Enemy enemy = other.GetComponent(Enemy);
        // Si l'ennemi est valide, infligez-lui des dégâts
        if (enemy != null)
        {
            enemy.TakeDamage(damageAmount);
        }

        // Détruisez le projectile après avoir touché l'ennemi
        Destroy(gameObject);
    }
}
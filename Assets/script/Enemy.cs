using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 3; // Points de vie max de l'ennemi
    private int currentHealth; // Points de vie actuels de l'ennemi

    public GameObject dropObject;   
    private void Start()
    {
        currentHealth = maxHealth; // Initialisez les points de vie actuels avec les points de vie max au démarrage
    }

    // Méthode pour réduire la santé de l'ennemi
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Réduisez les points de vie actuels de l'ennemi

        // Vérifiez si l'ennemi est mort
        if (currentHealth <= 0)
        {
            Die(); // Appel de la méthode Die si l'ennemi est mort
        }
    }

    // Méthode appelée lorsque l'ennemi meurt
    private void Die()
    {
        if (dropObject != null)
        {
            Instantiate(dropObject, transform.position, Quaternion.identity);
        }
        // Ajoutez ici tout code à exécuter lorsque l'ennemi meurt (par exemple, animation, son, score, etc.)
        Destroy(gameObject); // Détruisez l'ennemi
    }
}

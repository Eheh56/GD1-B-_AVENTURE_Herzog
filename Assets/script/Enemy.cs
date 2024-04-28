using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 3; // Points de vie max de l'ennemi
    private int currentHealth; // Points de vie actuels de l'ennemi

    public GameObject dropObject;   
    private void Start()
    {
        currentHealth = maxHealth; // Initialisez les points de vie actuels avec les points de vie max au d�marrage
    }

    // M�thode pour r�duire la sant� de l'ennemi
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // R�duisez les points de vie actuels de l'ennemi

        // V�rifiez si l'ennemi est mort
        if (currentHealth <= 0)
        {
            Die(); // Appel de la m�thode Die si l'ennemi est mort
        }
    }

    // M�thode appel�e lorsque l'ennemi meurt
    private void Die()
    {
        if (dropObject != null)
        {
            Instantiate(dropObject, transform.position, Quaternion.identity);
        }
        // Ajoutez ici tout code � ex�cuter lorsque l'ennemi meurt (par exemple, animation, son, score, etc.)
        Destroy(gameObject); // D�truisez l'ennemi
    }
}

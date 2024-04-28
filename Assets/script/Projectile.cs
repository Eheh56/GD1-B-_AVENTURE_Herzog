using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with is an enemy
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            // Destroy this object
            Destroy(gameObject);

            // Take 1 damage from the enemy
            enemy.TakeDamage(1);
        }
    }
}
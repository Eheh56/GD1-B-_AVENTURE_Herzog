using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string sceneToLoad; // Le nom de la scène à charger
    private bool playerInRange = false; // Variable pour vérifier si le joueur est à portée de la plaque

    void Update()
    {
        // Vérifie si le joueur est en collision avec la plaque et appuie sur la touche E
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            // Charge la nouvelle scène
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // Méthode appelée lorsque le joueur entre en collision avec la plaque
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Vérifie si le GameObject en collision est le joueur
        {
            playerInRange = true;
        }
    }

    // Méthode appelée lorsque le joueur quitte la collision avec la plaque
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Vérifie si le GameObject en collision est le joueur
        {
            playerInRange = false;
        }
    }
}

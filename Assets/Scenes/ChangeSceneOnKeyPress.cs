using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string sceneToLoad; // Le nom de la sc�ne � charger
    private bool playerInRange = false; // Variable pour v�rifier si le joueur est � port�e de la plaque

    void Update()
    {
        // V�rifie si le joueur est en collision avec la plaque et appuie sur la touche E
        if (Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            // Charge la nouvelle sc�ne
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // M�thode appel�e lorsque le joueur entre en collision avec la plaque
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // V�rifie si le GameObject en collision est le joueur
        {
            playerInRange = true;
        }
    }

    // M�thode appel�e lorsque le joueur quitte la collision avec la plaque
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // V�rifie si le GameObject en collision est le joueur
        {
            playerInRange = false;
        }
    }
}

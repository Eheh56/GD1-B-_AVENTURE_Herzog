using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Changez la touche selon vos préférences
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Arrête le temps de jeu
        // Mettez en pause d'autres éléments du jeu comme la musique, les mouvements, etc.
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Reprendre le temps de jeu normal
        // Reprenez d'autres éléments du jeu comme la musique, les mouvements, etc.
        isPaused = false;
    }
}
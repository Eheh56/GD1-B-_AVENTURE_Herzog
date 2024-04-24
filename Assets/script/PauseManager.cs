using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Changez la touche selon vos pr�f�rences
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Arr�te le temps de jeu
        // Mettez en pause d'autres �l�ments du jeu comme la musique, les mouvements, etc.
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Reprendre le temps de jeu normal
        // Reprenez d'autres �l�ments du jeu comme la musique, les mouvements, etc.
        isPaused = false;
    }
}
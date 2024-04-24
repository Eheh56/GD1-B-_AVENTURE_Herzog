using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject canvasToShow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();

        if (collectible != null)
        {
            collectible.Collect();

            // Activez seulement le Canvas sp�cifi�
            canvasToShow.SetActive(true);
        }
    }
}
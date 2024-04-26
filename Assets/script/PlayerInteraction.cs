using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private BottleCollectible currentInteractable; // R�f�rence � l'objet actuellement interactif

    // D�finir l'objet actuellement interactif
    public void SetInteractable(BottleCollectible interactable)
    {
        currentInteractable = interactable;
    }

    // Appel� lorsque le joueur interagit avec un objet (par exemple, en appuyant sur une touche)
    public void Interact()
    {
        // V�rifiez s'il y a un objet interactif
        if (currentInteractable != null)
        {
            // Ramassez la bouteille
            currentInteractable.Collect();
        }
    }
}

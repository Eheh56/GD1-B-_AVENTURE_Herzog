using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private BottleCollectible currentInteractable; // Référence à l'objet actuellement interactif

    // Définir l'objet actuellement interactif
    public void SetInteractable(BottleCollectible interactable)
    {
        currentInteractable = interactable;
    }

    // Appelé lorsque le joueur interagit avec un objet (par exemple, en appuyant sur une touche)
    public void Interact()
    {
        // Vérifiez s'il y a un objet interactif
        if (currentInteractable != null)
        {
            // Ramassez la bouteille
            currentInteractable.Collect();
        }
    }
}

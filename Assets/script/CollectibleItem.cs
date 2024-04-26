using UnityEngine;

public class BottleCollectible : MonoBehaviour
{
    public GameObject collectedBottle; // Référence à la bouteille ramassée
    public Transform canvas; // Référence au canvas où afficher la bouteille
    public KeyCode interactKey = KeyCode.E; // Touche pour interagir avec la bouteille

    private bool canInteract = false; // Indique si le joueur peut interagir avec la bouteille

    private void Update()
    {
        // Vérifie si le joueur peut interagir avec la bouteille et appuie sur la touche "E"
        if (canInteract && Input.GetKeyDown(interactKey))
        {
            // Ramassez la bouteille
            Collect();
        }
    }

    // Appelé lorsque le joueur entre dans la zone de ramassage
    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet qui entre en collision a un Rigidbody (ce qui indique généralement un joueur)
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Affichez un message à l'utilisateur pour lui indiquer comment ramasser la bouteille
            Debug.Log("Appuyez sur '" + interactKey.ToString() + "' pour ramasser la bouteille.");
            canInteract = true;
        }
    }

    // Appelé lorsque le joueur quitte la zone de ramassage
    private void OnTriggerExit(Collider other)
    {
        // Vérifie si l'objet qui sort de la zone de ramassage est le joueur
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            canInteract = false;
        }
    }

    // Fonction de collecte de la bouteille
    public void Collect()
    {
        // Désactivez la bouteille
        collectedBottle.SetActive(false);

        // Instanciez la bouteille ramassée dans le canvas
        GameObject instantiatedBottle = Instantiate(collectedBottle, canvas);

        // Réinitialisez la position et l'échelle de la bouteille dans le canvas
        instantiatedBottle.transform.localPosition = Vector3.zero;
        instantiatedBottle.transform.localScale = Vector3.one;
    }
}

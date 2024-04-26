using UnityEngine;

public class BottleCollectible : MonoBehaviour
{
    public GameObject collectedBottle; // R�f�rence � la bouteille ramass�e
    public Transform canvas; // R�f�rence au canvas o� afficher la bouteille
    public KeyCode interactKey = KeyCode.E; // Touche pour interagir avec la bouteille

    private bool canInteract = false; // Indique si le joueur peut interagir avec la bouteille

    private void Update()
    {
        // V�rifie si le joueur peut interagir avec la bouteille et appuie sur la touche "E"
        if (canInteract && Input.GetKeyDown(interactKey))
        {
            // Ramassez la bouteille
            Collect();
        }
    }

    // Appel� lorsque le joueur entre dans la zone de ramassage
    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si l'objet qui entre en collision a un Rigidbody (ce qui indique g�n�ralement un joueur)
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Affichez un message � l'utilisateur pour lui indiquer comment ramasser la bouteille
            Debug.Log("Appuyez sur '" + interactKey.ToString() + "' pour ramasser la bouteille.");
            canInteract = true;
        }
    }

    // Appel� lorsque le joueur quitte la zone de ramassage
    private void OnTriggerExit(Collider other)
    {
        // V�rifie si l'objet qui sort de la zone de ramassage est le joueur
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            canInteract = false;
        }
    }

    // Fonction de collecte de la bouteille
    public void Collect()
    {
        // D�sactivez la bouteille
        collectedBottle.SetActive(false);

        // Instanciez la bouteille ramass�e dans le canvas
        GameObject instantiatedBottle = Instantiate(collectedBottle, canvas);

        // R�initialisez la position et l'�chelle de la bouteille dans le canvas
        instantiatedBottle.transform.localPosition = Vector3.zero;
        instantiatedBottle.transform.localScale = Vector3.one;
    }
}

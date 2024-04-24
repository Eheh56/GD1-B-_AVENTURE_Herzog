using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUI; // Référence à l'interface utilisateur de l'inventaire
    public GameObject darkBackground; // Référence au panneau sombre de fond
    public GameObject gameObjectToDisable; // Référence au GameObject supplémentaire à désactiver

    void Start()
    {
        inventoryUI.SetActive(false); // Désactiver l'interface utilisateur de l'inventaire au démarrage
        darkBackground.SetActive(false); // Désactiver le panneau sombre au démarrage
        if (gameObjectToDisable != null)
        {
            gameObjectToDisable.SetActive(true); // Activer le GameObject supplémentaire au démarrage
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // Si la touche Tab est enfoncée
        {
            ToggleInventory(); // Ouvre ou ferme l'inventaire
        }
    }

    void ToggleInventory()
    {
        bool inventoryActive = !inventoryUI.activeSelf;
        inventoryUI.SetActive(inventoryActive); // Active ou désactive l'interface utilisateur de l'inventaire
        darkBackground.SetActive(inventoryActive); // Active ou désactive le panneau sombre

        if (gameObjectToDisable != null)
        {
            gameObjectToDisable.SetActive(!inventoryActive); // Active ou désactive le GameObject supplémentaire en fonction de l'état de l'inventaire
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUI; // R�f�rence � l'interface utilisateur de l'inventaire
    public GameObject darkBackground; // R�f�rence au panneau sombre de fond
    public GameObject gameObjectToDisable; // R�f�rence au GameObject suppl�mentaire � d�sactiver

    void Start()
    {
        inventoryUI.SetActive(false); // D�sactiver l'interface utilisateur de l'inventaire au d�marrage
        darkBackground.SetActive(false); // D�sactiver le panneau sombre au d�marrage
        if (gameObjectToDisable != null)
        {
            gameObjectToDisable.SetActive(true); // Activer le GameObject suppl�mentaire au d�marrage
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // Si la touche Tab est enfonc�e
        {
            ToggleInventory(); // Ouvre ou ferme l'inventaire
        }
    }

    void ToggleInventory()
    {
        bool inventoryActive = !inventoryUI.activeSelf;
        inventoryUI.SetActive(inventoryActive); // Active ou d�sactive l'interface utilisateur de l'inventaire
        darkBackground.SetActive(inventoryActive); // Active ou d�sactive le panneau sombre

        if (gameObjectToDisable != null)
        {
            gameObjectToDisable.SetActive(!inventoryActive); // Active ou d�sactive le GameObject suppl�mentaire en fonction de l'�tat de l'inventaire
        }
    }
}

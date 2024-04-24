using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    // Déclaration de la variable de pièces, accessible depuis n'importe où
    public static int coinCount = 0;

    // Référence aux TextMeshPro dans les Canvas 1 et 2
    public TextMeshProUGUI coinText1;
    public TextMeshProUGUI coinText2;

    // Fonction pour mettre à jour les compteurs de pièces dans les deux Canvas
    public void UpdateCoinCount()
    {
        coinText1.text = coinCount.ToString();
        coinText2.text = coinCount.ToString();
    }
}

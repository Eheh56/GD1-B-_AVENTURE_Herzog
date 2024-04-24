using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    // D�claration de la variable de pi�ces, accessible depuis n'importe o�
    public static int coinCount = 0;

    // R�f�rence aux TextMeshPro dans les Canvas 1 et 2
    public TextMeshProUGUI coinText1;
    public TextMeshProUGUI coinText2;

    // Fonction pour mettre � jour les compteurs de pi�ces dans les deux Canvas
    public void UpdateCoinCount()
    {
        coinText1.text = coinCount.ToString();
        coinText2.text = coinCount.ToString();
    }
}

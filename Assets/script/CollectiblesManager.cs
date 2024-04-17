using UnityEngine;
using TMPro;

public class CollectiblesManager : MonoBehaviour
{
    public TextMeshProUGUI gemUI;
    int numGemsCollected = 0;

    // Example of another collectible type
    //public TextMeshProUGUI diamondUI;
    //int numDiamondsCollected = 0;

    private void OnEnable()
    {
        Gem.OnGemCollected += GemCollected;
        //Diamond.OnDiamondCollected += DiamondCollected;
    }

    private void OnDisable()
    {
        Gem.OnGemCollected -= GemCollected;
        //Diamond.OnDiamondCollected -= DiamondCollected;
    }

    private void GemCollected()
    {
        numGemsCollected++;
        gemUI.text = numGemsCollected.ToString();
    }

    //private void DiamondCollected()
    //{
    //    numDiamondsCollected++;
    //    diamondUI.text = numDiamondsCollected.ToString();
    //}
}
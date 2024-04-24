using UnityEngine;
using TMPro;

public class CollectiblesManager : MonoBehaviour
{
    public TextMeshProUGUI gemUI1;
    public TextMeshProUGUI gemUI2;
    int numGemsCollected = 0;

    private void OnEnable()
    {
        Gem.OnGemCollected += GemCollected;
    }

    private void OnDisable()
    {
        Gem.OnGemCollected -= GemCollected;
    }

    private void GemCollected()
    {
        numGemsCollected++;
        gemUI1.text = numGemsCollected.ToString();
        gemUI2.text = numGemsCollected.ToString();
    }
}

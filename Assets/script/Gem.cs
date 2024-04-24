using System;
using UnityEngine;

public class Gem : MonoBehaviour, ICollectible
{
    public static event Action OnGemCollected;

    public void Collect()
    {
        OnGemCollected?.Invoke();
        Debug.Log("Gem collected!");
        Destroy(gameObject);
    }
}

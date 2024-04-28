using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Cr�e des projectiles
/// </summary>
public class WeaponScript : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;
    //--------------------------------
    // 1 - Designer variables
    //--------------------------------

    /// <summary>
    /// Prefab du projectile
    /// </summary>
    public Transform shotPrefab;

    /// <summary>
    /// Temps de rechargement entre deux tirs
    /// </summary>
    public float shootingRate = 0.25f;

    //--------------------------------
    // 2 - Rechargement
    //--------------------------------

    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);
        StartCoroutine(End());
    }

    private IEnumerator End()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
    }

    /// <summary>
    /// Cr�ation d'un projectile si possible
    /// </summary>
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;

            body.velocity = Vector3.right * speed;
        }
    }

    /// <summary>
    /// L'arme est charg�e ?
    /// </summary>
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }

}

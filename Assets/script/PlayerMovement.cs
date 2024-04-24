using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool isPaused = false;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    public GameObject bullet;
    public Transform weapon;
    public Transform shot_point;
    public float offset;


    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Arrête le temps de jeu
        // Mettez en pause d'autres éléments du jeu comme la musique, les mouvements, etc.
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Reprendre le temps de jeu normal
        // Reprenez d'autres éléments du jeu comme la musique, les mouvements, etc.
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Changez la touche selon vos préférences
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
        if (isPaused == false)
        {
            change = Vector3.zero;
            change.x = Input.GetAxisRaw("Horizontal");
            change.y = Input.GetAxisRaw("Vertical");
            if (change != Vector3.zero)
            {
                MoveCharacter();
                animator.SetFloat("moveX", change.x);
                animator.SetFloat("moveY", change.y);
            }

            bool shoot = Input.GetButtonDown("Fire1");
            shoot |= Input.GetButtonDown("Fire2");
            if (shoot)
            {
                Instantiate(bullet, shot_point.position, shot_point.rotation);
            }
            //AIM
            Vector3 displacement = weapon.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float angle = -Mathf.Atan2(displacement.x, displacement.y) * Mathf.Rad2Deg;
            weapon.rotation = Quaternion.Euler(0, 0, angle + offset);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
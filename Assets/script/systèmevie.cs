using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class systèmevie : MonoBehaviour
{
    public Rigidbody2D rgbd;
    public int pvTotal = 3;
    public int pv;
    public int damage = 1;

    public Sprite heart_empty;
    public Sprite heart_full;
    public Image[] hearts;





    void Start()
    {
        pv = pvTotal;
    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("losepv");
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < pv)
            {
                hearts[i].sprite = heart_full;
            }
            else
            {
                hearts[i].sprite = heart_empty;
            }
            if (pv <= 0)
            {
                SceneManager.LoadScene("DeathScreen");
            }
        }
    }
        
}

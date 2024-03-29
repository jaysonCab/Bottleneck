using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bossScript : MonoBehaviour
{
    mainMenuController backScript;

    public int health = 100;
    public GameObject deathEffect;
    public Slider healthBar;

    private void Start()
    {
        backScript = GameObject.FindGameObjectWithTag("mainMenuController").GetComponent<mainMenuController>();
    }

    private void Update()
    {
        healthBar.value = health;
    }

    public void damageTaken (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            die();
        }
    }

    private void die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }


    //void Start()
    //{
        
    //}

    //void Update()
    //{
        
    //}
}

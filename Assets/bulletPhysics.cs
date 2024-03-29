using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12.5f | transform.position.x > 12.5f)
        {
            Destroy(gameObject);
            Debug.Log("Projectile deleted!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<bossScript>(out bossScript enemyComponent))
        {
            enemyComponent.damageTaken(1);
            Destroy(gameObject);
        }
       
    }
}

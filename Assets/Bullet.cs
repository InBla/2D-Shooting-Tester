using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float damage = 3;
    private Rigidbody rb;

    private void Awake()
    {
        Destroy(gameObject, damage);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            var healthComponent = collision.GetComponent<EnemyHealth>();
            if(healthComponent != null)
            {
                healthComponent.TakeDamage(1);
                //healthComponent.Heal(1);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}

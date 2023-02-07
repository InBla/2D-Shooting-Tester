using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float enemiesMaxHealth = 3f;
    [SerializeField] float enemiesCurrentHealth;

    [SerializeField] Animator anim;
    private void Start()
    {
        enemiesCurrentHealth = enemiesMaxHealth;
    }
    public void TakeDamage(float amount)
    {
        ///Play sound
        

        enemiesCurrentHealth -= amount;

        if (enemiesCurrentHealth <= 0)
        {
            ///We're dead
            ///Play Death Animation
            anim.SetBool("IsDead", true);

            ///Destroy enemy
            Destroy(gameObject);

            ///Show GameOver screen
        }
    }
    public void Heal(float amount)
    {
        ///Play sound

        enemiesCurrentHealth += amount;

        if (enemiesCurrentHealth > enemiesMaxHealth)
        {
            enemiesCurrentHealth = enemiesMaxHealth;
        }
    }

}

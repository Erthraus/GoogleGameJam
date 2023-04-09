using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigBossHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    Animator animator; 
    
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
       
    }
    
    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Die(); 
            Destroy(gameObject); 
        }
        else
        {
            animator.SetTrigger("Damage"); 
        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);
    }
}

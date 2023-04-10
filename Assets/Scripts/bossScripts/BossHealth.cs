using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public Transform playerTransform;
    private Animator _animator;
    private float Distance;
    public float maxHealth;
    public float BossDestroyTime;
    float currentHealth;

    BoxCollider2D bosscollider;

    bool isDead;

    Animator animator; 
    
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        bosscollider = GetComponent<BoxCollider2D>();
        _animator = GetComponent<Animator>();
       
    }
    private void Update()
    {
        CheckisDead();
        Distance = Vector2.Distance(playerTransform.position, transform.position);
        _animator.SetFloat("Distance", Distance);
        //Debug.Log(Distance);
    }

    public void TakeDamage(float damage)
    {
        if (isDead)
        {
            return;
        }
        currentHealth -= damage;
        if (!AudioManager.instance.sfx[3].isPlaying)
        {
            AudioManager.instance.PlaySFX(3);
        }
        animator.SetTrigger("Damage");
        if (currentHealth <= 0)
        {
            isDead = true;
            currentHealth = 0;
            animator.SetTrigger("Death");
            StartCoroutine(DestroyBoss());
            if (!AudioManager.instance.sfx[2].isPlaying)
            {
                AudioManager.instance.PlaySFX(2);
            }
            
        }
       
    }

    void CheckisDead()
    {
        animator.SetBool("isDead", isDead);
        
    }

    IEnumerator DestroyBoss()
    {
        bosscollider.enabled = false;
        yield return new WaitForSeconds(BossDestroyTime);
        Destroy(gameObject);
    }
}

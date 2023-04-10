using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //public PauseMenuScript pms;
    /*public GameObject DarkMenuObj;
    public GameObject DieMenuObj;*/
    public float maxHealth;
    public float alphaValue;
    public float hitTime;
    //public float afterDeath;
    float currentHealth;
    bool isDead = false;

    Animator anim;
    Rigidbody2D playerRb;
    PlayerControl playercontrol;
    SpriteRenderer playerSR;
    Color originalColor;
    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody2D>();
        playercontrol = GetComponent<PlayerControl>();
        playerSR = GetComponent<SpriteRenderer>();
        originalColor = playerSR.color;
        


    }


    void Update()
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        anim.SetBool("isDead", isDead);
        

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{


    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        if (isDead)
    //        {
    //            return;
    //        }
    //        currentHealth -= collision.GetComponent<BossWeapon>().attackDamage;
    //        anim.SetTrigger("Hit");
    //        if (!AudioManager.instance.sfx[0].isPlaying)
    //        {
    //            AudioManager.instance.PlaySFX(0);
    //        }


    //        if (currentHealth <= 0)
    //        {
    //            isDead = true;
    //            currentHealth = 0;
    //            anim.SetTrigger("Death");
    //            Destroy(playercontrol);
    //            if (!AudioManager.instance.sfx[1].isPlaying)
    //            {
    //                AudioManager.instance.PlaySFX(1);
    //            }
    //        }
           
               
    //    }

    //}
   public void TakeDamage(float damage)
    {
        if (isDead)
        {
            return;
        }
        currentHealth -= damage;
        anim.SetTrigger("Hit");
        if (!AudioManager.instance.sfx[0].isPlaying)
        {
            AudioManager.instance.PlaySFX(0);
        }


        if (currentHealth <= 0)
        {
            isDead = true;
            currentHealth = 0;
            anim.SetTrigger("Death");
            Destroy(playercontrol);
            if (!AudioManager.instance.sfx[1].isPlaying)
            {
                AudioManager.instance.PlaySFX(1);
            }

            /*Paused = true;
            Time.timeScale = 0.0f;
            DarkMenuObj.SetActive(true);
            DieMenuObj.SetActive(true);*/

            //pms.Paused = true;
        }
    }
    
  
    //IEnumerator DontMove()
    //{
    //    yield return new WaitForSeconds(afterDeath);
    //    Destroy(playercontrol);
    //}
    
}

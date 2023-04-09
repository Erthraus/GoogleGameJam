using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            Debug.Log("Collision");
        }
    }
}

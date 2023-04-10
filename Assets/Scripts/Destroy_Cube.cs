using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Cube : MonoBehaviour
{
    public float Destroy_Time;

    void Start()
    {
        StartCoroutine(DestroyTheCube());
    }

    void Update()
    {
        
    }

    IEnumerator DestroyTheCube()
    {
        yield return new WaitForSeconds(Destroy_Time);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAttack : MonoBehaviour
{

    public float DestroyTime;

 [SerializeField] GameObject cubePrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(cubePrefab, (Vector2)spawnPosition, Quaternion.identity);
        }

        
    }

   /* IEnumerator DestroyCube()
    {
        yield return new WaitForSeconds(DestroyTime);
        Destroy(GameObject.FindGameObjectWithTag(tagToDestroy);)
    }*/
}

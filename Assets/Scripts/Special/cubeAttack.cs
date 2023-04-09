using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAttack : MonoBehaviour
{
    /*    public GameObject cubePrefab;

        public void CreateNewCube()
        {
            Instantiate(cubePrefab);
        }
    */

 [SerializeField] GameObject cubePrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject g = Instantiate(cubePrefab, (Vector2)spawnPosition, Quaternion.identity);
        }
    }
}

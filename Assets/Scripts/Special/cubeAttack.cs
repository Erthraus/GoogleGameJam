using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAttack : MonoBehaviour
{
    public GameObject cubePrefab;

    public void CreateNewCube()
    {
        Instantiate(cubePrefab);
    }
}

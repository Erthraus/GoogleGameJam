using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton : MonoBehaviour
{
    public GameObject player;
    public GameObject cubePrefab;

    public void GenerateCube()
    {
        Vector3 spawnPosition = player.transform.position;
        GameObject g = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}

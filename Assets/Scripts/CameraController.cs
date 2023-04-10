using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxDistance;
    [SerializeField] private float cameraMoveSpeed;

    void LateUpdate()
    {
        Debug.Log("Player Y position: " + player.position.y);
        if (player.position.y > minHeight)
        {
            float distance = Mathf.Clamp(player.position.y - minHeight, 0, maxDistance);
            transform.position = Vector3.Lerp(transform.position, transform.position - transform.up * distance, cameraMoveSpeed * Time.deltaTime);
        }
    }
}
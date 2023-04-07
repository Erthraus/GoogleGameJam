using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;
    private bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = Input.GetKey(KeyCode.D);
        animator.SetBool("isRunning", isRunning);
    }
}
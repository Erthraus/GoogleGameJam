using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public static bool isCutsceneOn;
    public Animator camAnim;
    public PlayerControl pc;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pc.playerSpeed = 0;
            isCutsceneOn = true;
            camAnim.SetBool("Cutscene", true);
            Invoke(nameof(StopCutscene), 2f);
        }
    }

    void StopCutscene()
    {
        pc.playerSpeed = 10;
        isCutsceneOn = false;
        camAnim.SetBool("Cutscene", false);
        Destroy(gameObject);
    }
}

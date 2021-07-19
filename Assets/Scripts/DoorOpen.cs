using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == ("Player"))
        {
            animator.SetBool("Opened", true);
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == ("Player"))
        {
            animator.SetBool("Opened", false);
        }
    }
}

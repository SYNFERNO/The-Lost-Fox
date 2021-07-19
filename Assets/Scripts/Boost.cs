using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    Animator animator;
    float boostjump = 16000f;

    private void Awake() {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
                float realjump = other.GetComponent<CharacterController2d>().m_JumpForce;

                other.GetComponent<CharacterController2d>().m_JumpForce = boostjump;

                animator.SetTrigger("Boost");
                other.GetComponent<CharacterController2d>().Move(0, false, true, false);
                other.GetComponent<CharacterController2d>().m_JumpForce = realjump;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {
                float realjump = other.gameObject.GetComponent<CharacterController2d>().m_JumpForce;

                other.gameObject.GetComponent<CharacterController2d>().m_JumpForce = boostjump;

                animator.SetTrigger("Boost");
                //other.gameObject.GetComponent<CharacterController2d>().Move(0, false, true, false);
                //other.gameObject.GetComponent<CharacterController2d>().m_JumpForce = realjump;
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, boostjump));
        }
    }
}

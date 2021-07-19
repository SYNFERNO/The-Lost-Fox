using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2d controller2D;
    public Animator anim;
    float horizontalMove = 0f;
    public float runSpeed = 10f;
    bool jump = false;
    bool crouch = false;
    bool dash = false;

    private void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("IsJump", true);
        }

        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if(Input.GetButtonDown("Dash"))
        {
            dash = true;
        }
    }

    public void OnLanding()
    {
        anim.SetBool("IsJump", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        anim.SetBool("IsCrouch", isCrouching);
    }

    private void FixedUpdate() {
        controller2D.Move(horizontalMove, crouch, jump, dash);
        jump = false;
        dash = false;
    }
}

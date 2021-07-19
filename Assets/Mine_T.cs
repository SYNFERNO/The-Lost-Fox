using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_T : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player")
        {
            GameLevelManager.Instance.m_PlayerCurrentHealth -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            GameLevelManager.Instance.m_PlayerCurrentHealth -= 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPGem : MonoBehaviour
{
    private int m_point = 1;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            GameLevelManager.Instance.AddScore(m_point);
            Destroy(gameObject);
        }
    }
}

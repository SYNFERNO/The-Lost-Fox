using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallZone : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            if(GameLevelManager.Instance.m_PlayerCurrentHealth >= 1 )
            {
                GameLevelManager.Instance.ReduceHealth(1);
                other.transform.position = spawnPoint.position;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float MaxHealth;
    [SerializeField] private float Health;

    private void Start() {
        MaxHealth = GameLevelManager.Instance.m_PlayerMaxHealth;
    }

    private void Update() {
        Health = GameLevelManager.Instance.m_PlayerCurrentHealth;
    }
}

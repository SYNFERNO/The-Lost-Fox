using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineObs : MonoBehaviour
{
    public GameObject minetrigger;
    Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("tes");
            Invoke("MineTrigerred", 1.0f);
        }
    }

    void MineTrigerred()
    {
        animator.SetBool("Triggered", true);
        minetrigger.SetActive(true);
        Invoke("MineNotTrigerred", 1.0f);
    }

    void MineNotTrigerred()
    {
        animator.SetBool("Triggered", false);
        minetrigger.SetActive(false);
    }
}

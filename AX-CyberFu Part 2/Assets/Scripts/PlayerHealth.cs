using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentPlayerHealth = 40;
    public int enemyDamage = 5;
    public PlayerExplosionParticles particles;
    private Animator playerAnimator;
   
    void Start()
    {
        currentPlayerHealth = 40;
        enemyDamage = 4;
        playerAnimator = GetComponent<Animator>();
        particles = GetComponent<PlayerExplosionParticles>();
    }
    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");

        if(currentPlayerHealth <= 0)
        {
            particles.Explode();
            Invoke("ReloadScene", 5);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("CyberFu");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "HitCollider")
        {
            HurtPlayer();
        }
    }
}

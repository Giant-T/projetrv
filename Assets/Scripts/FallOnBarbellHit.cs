using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AudioSource))]
public class FallOnBarbellHit : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        // Si l'autre objet est une haltere
        if (other.gameObject.CompareTag("Barbell"))
        {
            animator.SetTrigger("Fall");
            audioSource.Play();
        }
    }
}

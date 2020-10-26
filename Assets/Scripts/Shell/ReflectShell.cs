﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectShell : MonoBehaviour
{
    public LayerMask m_TankMask;                        // Used to filter what the explosion affects, this should be set to "Players".
    public ParticleSystem m_ExplosionParticles;         // Reference to the particles that will play on explosion.
    public AudioSource m_ExplosionAudio;                // Reference to the audio that will play on explosion.
    public float m_MaxDamage = 100f;                    // The amount of damage done if the explosion is centred on a tank.
    public float m_ExplosionForce = 1000f;              // The amount of force added to a tank at the centre of the explosion.
    public float m_MaxLifeTime = 2.0f;                    // The time in seconds before the shell is removed.
    public float m_ExplosionRadius = 5f;                // The maximum distance away from the explosion tanks can be and are still affected.

    void Start()
    {
        Destroy(gameObject, m_MaxLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Collect all the colliders in a sphere from the shell's current position to a radius of the explosion radius.
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius, m_TankMask);

        // Go through all the colliders...
        for (int i = 0; i < colliders.Length; i++)
        {
            // ... and find their rigidbody.
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

            // If they don't have a rigidbody, go on to the next collider.
            if (!targetRigidbody)
                continue;

            // Add an explosion force.
            targetRigidbody.AddExplosionForce(m_ExplosionForce, transform.position, m_ExplosionRadius);

        }

        if (other.gameObject.tag == "Player")
        {
           m_ExplosionParticles.transform.parent = null;

         // Play the particle system.
         m_ExplosionParticles.Play();

         // Play the explosion sound effect.
         m_ExplosionAudio.Play();

         // Once the particles have finished, destroy the gameobject they are on.
         ParticleSystem.MainModule mainModule = m_ExplosionParticles.main;
         Destroy(m_ExplosionParticles.gameObject, mainModule.duration);

         // Destroy the shell.
         Destroy(gameObject);
        }

        // Unparent the particles from the shell.
        /* m_ExplosionParticles.transform.parent = null;

         // Play the particle system.
         m_ExplosionParticles.Play();

         // Play the explosion sound effect.
         m_ExplosionAudio.Play();

         // Once the particles have finished, destroy the gameobject they are on.
         ParticleSystem.MainModule mainModule = m_ExplosionParticles.main;
         Destroy(m_ExplosionParticles.gameObject, mainModule.duration);

         // Destroy the shell.
         Destroy(gameObject);*/
    }

}
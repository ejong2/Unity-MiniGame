using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;

    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;

    public float maxDamage = 100f;
    public float explosionForce = 1000f;
    public float lifeTime = 10f;
    public float explosionRadius = 20f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, whatIsProp);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();
            if (targetRigidbody != null)
            {
                targetRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }

            Prop targetProp = colliders[i].GetComponent<Prop>();
            if (targetProp != null)
            {
                float damage = CalculateDamage(colliders[i].transform.position);
                targetProp.TakeDamage(damage);
            }
        }

        ParticleSystem instantiatedParticle = Instantiate(explosionParticle, transform.position, transform.rotation); // ⭐ 추가
        AudioSource instantiatedAudio = Instantiate(explosionAudio, transform.position, transform.rotation); // ⭐ 추가

        if (instantiatedAudio != null && instantiatedAudio.enabled) // ⭐ 추가
        {
            instantiatedAudio.Play();
        }

        Destroy(instantiatedParticle.gameObject, instantiatedParticle.main.duration); // ⭐ 수정
        Destroy(gameObject);
    }

    private float CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float distance = explosionToTarget.magnitude;

        float edgeToCenterDistance = explosionRadius - distance;

        float percentage = edgeToCenterDistance / explosionRadius;

        float damage = maxDamage * percentage;

        damage = Mathf.Max(0, damage);

        return damage;
    }
}
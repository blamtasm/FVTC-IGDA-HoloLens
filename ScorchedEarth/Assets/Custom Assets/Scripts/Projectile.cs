using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour {

    public float DamageMinimum { get; set; }
    public float DamageMaximum { get; set; }
    public float Speed { get; set; }
    public float MaxDistance { get; set; }
    public double MaxFlightTime { get; set; }
    public float ExplosionRadius { get; set; }
    public GameObject ExplosionObject { get; set; }
    public ParticleSystem ExplosionParticles { get; set; }
    public bool SplitsProjectileOnCollision { get; set; }
    public GameObject SplitProjectile { get; set; }
    public AudioClip FireSoundEffect { get; set; }
    public AudioClip ExplosionSoundEffect { get; set; }
    public AudioClip FlightSoundEffect { get; set; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void Detonate();

    public abstract void OnCollisionEnter(Collider c);
}

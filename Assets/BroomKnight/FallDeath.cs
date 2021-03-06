﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour {
    private Health m_health;
    private Rigidbody m_rigidbody;

    private Animator m_animator;
    // Use this for initialization
    void Awake () {
        m_health = transform.root.GetComponent<Health>();
        m_rigidbody = transform.root.GetComponent<Rigidbody>();
        m_animator = transform.root.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Terrain")
        {
            m_health.M_Die(m_rigidbody.velocity);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Terrain")
        {
            m_health.M_Die(m_rigidbody.velocity);
        }
    }

    public void FallingAnim()
    {
        m_animator.SetTrigger("Falling");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHitbox : Actor
{
    public bool isPermament = false;

    public bool tickDamage = false;

    public float damageValue = 0f;

    [SerializeField]
    protected float hitboxLifetime = 4f;

    protected float lifetimeCounter = 0f;

    public float GetCurrentLifetime()
    {
        return lifetimeCounter;
    }

    protected DamageInfo thisDamageInfo = null;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Actor otherActor = collision.GetComponent<Actor>();

        if (otherActor)
        {
            otherActor.TakeDamage(this, damageValue, Owner, thisDamageInfo);
        }
    }

    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        if (tickDamage)
        {
            Actor otherActor = collision.GetComponent<Actor>();

            if (otherActor)
            {
                otherActor.TakeDamage(this, damageValue, Owner, thisDamageInfo);
            }
        }
    }

    protected virtual void Update()
    {
        if (!isPermament)
        {
            lifetimeCounter += Time.deltaTime;
            if (lifetimeCounter >= hitboxLifetime)
            {
                Destroy(gameObject);
            }
        }
    }
}
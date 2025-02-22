﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCState_FallingUnconscious : BullCState
{
    public override void EnterState()
    {
        base.EnterState();
        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.Play("Unconscious");
        myStateMachine.TheBullPawn.GetComponentInChildren<DamageHitbox>().GetComponent<Collider2D>().gameObject.SetActive(false);
    }
}

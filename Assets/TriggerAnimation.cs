using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;

    public void TriggerAnimation1(string trigger)
    {
        animator.SetTrigger(trigger);
    }
}

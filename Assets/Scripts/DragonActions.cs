using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonActions : MonoBehaviour
{

    public Animator dragonAnimator;
    private bool isFlying = false;

    private void OnMouseDown()
    {
        isFlying = !isFlying;
        dragonAnimator.SetBool("Flying", isFlying);
    }

}

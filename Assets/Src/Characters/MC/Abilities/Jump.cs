using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour, IAbility
{
    public CharacterController2D controller;

    public void performAbility()
    {
        controller.AttemptJump();
    }
}

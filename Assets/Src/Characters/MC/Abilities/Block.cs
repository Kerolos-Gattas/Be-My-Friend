using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour, IAbility
{
    public CharacterController2D controller;

    public void performAbility()
    {
        controller.AttemptBlock();
    }
}

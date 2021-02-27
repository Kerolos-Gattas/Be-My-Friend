using UnityEngine;

public class Cast : MonoBehaviour, IAbility
{
    public CharacterController2D controller;

    public void performAbility()
    {
        controller.AttemptCast();
    }
}

using System;
using UnityEngine;

public class McInput : MonoBehaviour
{
    public CharacterController2D controller;
    public Transform swordSelection;
    [SerializeField] private float speed = 40f;
    private McControls controls;
    private IAbility ability;
    private float horizontalMove = 0f;

    public void activateCharacter()
    {
        controls.MC.Enable();
        HandleCancelAbility();
        swordSelection.gameObject.SetActive(true);
    }

    public void deActivateCharacter()
    {
        controls.MC.Disable();
        HandleStop();
        HandleStartAbility();
        swordSelection.gameObject.SetActive(false);
    }

    private void Awake()
    {
        controls = new McControls();
        ability = this.GetComponent<IAbility>();
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false);
    }

    private void HandleMove(Single dir)
    {
        horizontalMove = dir * speed;
    }

    private void HandleStop()
    {
        horizontalMove = 0;
    }

    private void HandleStartAbility()
    {
        InvokeRepeating("ActiviateAbility", 0f, 0.1f);
    }

    private void ActiviateAbility()
    {
        ability.performAbility();
    }

    private void HandleCancelAbility()
    {
        CancelInvoke("ActiviateAbility");
    }

    private void OnEnable()
    {
        controls.MC.Move.started += context => HandleMove(context.ReadValue<Single>());
        controls.MC.Move.canceled += context => HandleStop();
        controls.MC.Ability.started += context => HandleStartAbility();
        controls.MC.Ability.canceled += context => HandleCancelAbility();
        controls.MC.Enable();
    }

    private void OnDisable()
    {
        controls.MC.Disable();
    }
}

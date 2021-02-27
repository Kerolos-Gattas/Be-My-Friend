using System;
using UnityEngine;

public class MCsManager : MonoBehaviour
{
    public MCsSelection mCsSelection;
    private McInput[] characters;
    private McControls controls;
    private int currentCharacterIndex = 0;

    private void Awake()
    {
        controls = new McControls();

        int characterCount = transform.childCount;
        characters = new McInput[characterCount];
        for (int i = 0; i < characterCount; i++)
        {
            characters[i] = transform.GetChild(i).GetComponent<McInput>();
        }
    }

    private void Start()
    {
        this.EnableCharacter(currentCharacterIndex, -1);
    }

    private void HandleSwitch(Single value)
    {
        int prevCharacterIndex = currentCharacterIndex;
        if (currentCharacterIndex + value == characters.Length)
        {
            currentCharacterIndex = 0;
        }
        else if (currentCharacterIndex + value < 0)
        {
            currentCharacterIndex = characters.Length - 1;
        }
        else
        {
            currentCharacterIndex = currentCharacterIndex + (int)value;
        }

        this.EnableCharacter(currentCharacterIndex, prevCharacterIndex);
        this.mCsSelection.selectCharacter(currentCharacterIndex, prevCharacterIndex);
    }

    private void EnableCharacter(int currentIndex, int prevIndex)
    {
        if (prevIndex != -1)
        {
            characters[prevIndex].deActivateCharacter();
        }
        else
        {
            foreach (McInput character in characters)
            {
                character.deActivateCharacter();
            }
        }
        characters[currentIndex].activateCharacter();
    }

    private void OnEnable()
    {
        controls.CharacterSelection.SwitchCharacter.performed += context => HandleSwitch(context.ReadValue<Single>());
        controls.CharacterSelection.Enable();
    }

    private void OnDisable()
    {
        controls.CharacterSelection.Disable();
    }
}

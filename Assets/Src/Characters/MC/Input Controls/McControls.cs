// GENERATED AUTOMATICALLY FROM 'Assets/Src/Characters/MC/Input Controls/McControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @McControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @McControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""McControls"",
    ""maps"": [
        {
            ""name"": ""MC"",
            ""id"": ""aa45079b-b240-4338-b3ea-a050da0d501f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""bfc6f5cd-cb8d-42a6-9778-9b782f5c707d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Ability"",
                    ""type"": ""Button"",
                    ""id"": ""7a4348b7-4121-4cd3-9237-ecbb0db5e06f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""dc25fd41-b79c-4619-a65b-6409eb25277e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f2880163-18b2-4853-82a4-77d61ccf14ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80e6c3ee-f050-4ff7-8328-ae4fc0f60641"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""1fddc5dc-ec0b-4539-bc77-b04f9804f372"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5d149833-50a4-4676-90b3-91599bdbf4dc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d3585f2d-952e-47ff-8038-ff6046e13518"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5528e018-f16c-4c29-9bd4-c948121565ef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CharacterSelection"",
            ""id"": ""6f946323-c321-4004-96f8-8a9ff46e7224"",
            ""actions"": [
                {
                    ""name"": ""SwitchCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""16fe8b71-84c5-466b-8fcf-279b04d35453"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""UpAndDown"",
                    ""id"": ""088f21cc-62bb-4cbd-bd15-aef7dbc2acf5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""80b9de7e-339c-4d8a-bd39-7377ded548ff"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""258eba47-c1be-494c-97be-7e16909682ea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""SwitchCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""9d984b68-31d7-45bb-8384-72af094a6b66"",
            ""actions"": [
                {
                    ""name"": ""RetryLevel"",
                    ""type"": ""Button"",
                    ""id"": ""a865cd96-113d-4967-84db-f380c19df230"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""53bf0f6d-f557-4af0-94ee-f6b031e9dbf7"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""RetryLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MC
        m_MC = asset.FindActionMap("MC", throwIfNotFound: true);
        m_MC_Move = m_MC.FindAction("Move", throwIfNotFound: true);
        m_MC_Ability = m_MC.FindAction("Ability", throwIfNotFound: true);
        // CharacterSelection
        m_CharacterSelection = asset.FindActionMap("CharacterSelection", throwIfNotFound: true);
        m_CharacterSelection_SwitchCharacter = m_CharacterSelection.FindAction("SwitchCharacter", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_RetryLevel = m_Menu.FindAction("RetryLevel", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // MC
    private readonly InputActionMap m_MC;
    private IMCActions m_MCActionsCallbackInterface;
    private readonly InputAction m_MC_Move;
    private readonly InputAction m_MC_Ability;
    public struct MCActions
    {
        private @McControls m_Wrapper;
        public MCActions(@McControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MC_Move;
        public InputAction @Ability => m_Wrapper.m_MC_Ability;
        public InputActionMap Get() { return m_Wrapper.m_MC; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MCActions set) { return set.Get(); }
        public void SetCallbacks(IMCActions instance)
        {
            if (m_Wrapper.m_MCActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Ability.started -= m_Wrapper.m_MCActionsCallbackInterface.OnAbility;
                @Ability.performed -= m_Wrapper.m_MCActionsCallbackInterface.OnAbility;
                @Ability.canceled -= m_Wrapper.m_MCActionsCallbackInterface.OnAbility;
            }
            m_Wrapper.m_MCActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Ability.started += instance.OnAbility;
                @Ability.performed += instance.OnAbility;
                @Ability.canceled += instance.OnAbility;
            }
        }
    }
    public MCActions @MC => new MCActions(this);

    // CharacterSelection
    private readonly InputActionMap m_CharacterSelection;
    private ICharacterSelectionActions m_CharacterSelectionActionsCallbackInterface;
    private readonly InputAction m_CharacterSelection_SwitchCharacter;
    public struct CharacterSelectionActions
    {
        private @McControls m_Wrapper;
        public CharacterSelectionActions(@McControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchCharacter => m_Wrapper.m_CharacterSelection_SwitchCharacter;
        public InputActionMap Get() { return m_Wrapper.m_CharacterSelection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterSelectionActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterSelectionActions instance)
        {
            if (m_Wrapper.m_CharacterSelectionActionsCallbackInterface != null)
            {
                @SwitchCharacter.started -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.performed -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnSwitchCharacter;
                @SwitchCharacter.canceled -= m_Wrapper.m_CharacterSelectionActionsCallbackInterface.OnSwitchCharacter;
            }
            m_Wrapper.m_CharacterSelectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchCharacter.started += instance.OnSwitchCharacter;
                @SwitchCharacter.performed += instance.OnSwitchCharacter;
                @SwitchCharacter.canceled += instance.OnSwitchCharacter;
            }
        }
    }
    public CharacterSelectionActions @CharacterSelection => new CharacterSelectionActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_RetryLevel;
    public struct MenuActions
    {
        private @McControls m_Wrapper;
        public MenuActions(@McControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RetryLevel => m_Wrapper.m_Menu_RetryLevel;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @RetryLevel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnRetryLevel;
                @RetryLevel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnRetryLevel;
                @RetryLevel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnRetryLevel;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RetryLevel.started += instance.OnRetryLevel;
                @RetryLevel.performed += instance.OnRetryLevel;
                @RetryLevel.canceled += instance.OnRetryLevel;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IMCActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAbility(InputAction.CallbackContext context);
    }
    public interface ICharacterSelectionActions
    {
        void OnSwitchCharacter(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnRetryLevel(InputAction.CallbackContext context);
    }
}

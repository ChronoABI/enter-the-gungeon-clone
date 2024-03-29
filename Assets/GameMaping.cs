//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameMaping.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GameMaping : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameMaping()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameMaping"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""33d04a11-44c3-4cbb-bfc6-46f9d1b0dbd9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b1e5dc2a-0123-492b-b78c-b19e3d9109e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""216aba8d-8c56-4236-9ce4-a90ffe56bc70"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Value"",
                    ""id"": ""4bd67faa-1757-4954-b7fa-41ec7ce093d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Use Blank"",
                    ""type"": ""Button"",
                    ""id"": ""ac45c5e5-10b9-4133-bda3-10047f1d758e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Value"",
                    ""id"": ""6ba43f1a-5512-4939-bea2-b80f21f48ba0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""cb4d3b0c-64ab-41bd-8640-c0fe74c9600f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next and Previous Gun"",
                    ""type"": ""Value"",
                    ""id"": ""9137c0b2-4908-41a7-9d14-707c0cb86420"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Next and previous Item"",
                    ""type"": ""Button"",
                    ""id"": ""350df00a-63d2-4cee-939c-4ec085393a04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop Gun(hold)"",
                    ""type"": ""Button"",
                    ""id"": ""690d993e-67e8-4ee0-a1c4-073410f8a03a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop Item(hold)"",
                    ""type"": ""Button"",
                    ""id"": ""05659b26-0203-4bb7-a61e-322499cc231f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow"",
                    ""id"": ""2a348571-6ec4-46de-974e-f87cd1e6fb98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""24f0e383-cfa1-4911-96b8-8f9967e88d6a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8826ad02-1955-4480-9826-f65d76069b5d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6d9b63ea-36c4-46ca-9066-fb4c24c58041"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dc8b19eb-ba82-4bcb-9293-6b0344475c75"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AWSD"",
                    ""id"": ""37417d6f-fbf6-485f-a178-5c77972ef749"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""56b5f087-839f-4e67-97b2-d21ffa8f2ab2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac003281-654a-4503-aa18-4963decf6452"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6eb15a88-032b-450d-b2bb-b4621ffd24c9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c72910a3-cfe0-41a8-b689-f38183072377"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""328a834e-719d-4070-b27e-edfa73ff5431"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fff24f8d-001f-4b74-a6b6-b4b7d9bf8558"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41e66949-26cf-436d-9b8c-049c319ee63d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Blank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1fec4af-7bfc-4e31-be32-5d770a78c045"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a375f1d-b7c4-4398-a441-18fda1037743"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8ed6aed1-2c04-4f3b-bb66-8778f264ecb3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and previous Item"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e8f5df0e-55d6-4367-9bdf-59480a01d470"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and previous Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f18300e4-394e-4ea1-87de-e99b23650144"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and previous Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""58047ccd-0128-45a1-af79-3369be1efaec"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop Gun(hold)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e24eb56-f409-4ff5-8418-f41e460c6a8a"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop Item(hold)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b62e577c-373f-4048-b3b7-64be4c28cb52"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and Previous Gun"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9d754444-9e58-4f34-8f4b-7183bd39b970"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and Previous Gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cd240f58-8122-42ee-a453-57ffd6645736"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next and Previous Gun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""afce1d6f-e31b-438b-aa68-ab25f0b8fcc2"",
            ""actions"": [
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""28a84ef9-77f6-4c22-acf0-18930258bfe7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9ec4f33a-e4d7-4282-a4f1-412cd5abd79d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""baa656c6-2149-4339-b5cc-9368576337b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""d5909567-b426-43d5-8319-75604272f549"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b6414d7-83f0-43ad-9409-cfa485f2bef9"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ac80162-1c83-47e2-9552-e7c120bff9dc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd25749c-b649-4fc6-aef5-ada43f34157b"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa1d7ef0-f83f-4baf-af2d-2c713f8b3958"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_UseBlank = m_Gameplay.FindAction("Use Blank", throwIfNotFound: true);
        m_Gameplay_Pickup = m_Gameplay.FindAction("Pickup", throwIfNotFound: true);
        m_Gameplay_Reload = m_Gameplay.FindAction("Reload", throwIfNotFound: true);
        m_Gameplay_NextandPreviousGun = m_Gameplay.FindAction("Next and Previous Gun", throwIfNotFound: true);
        m_Gameplay_NextandpreviousItem = m_Gameplay.FindAction("Next and previous Item", throwIfNotFound: true);
        m_Gameplay_DropGunhold = m_Gameplay.FindAction("Drop Gun(hold)", throwIfNotFound: true);
        m_Gameplay_DropItemhold = m_Gameplay.FindAction("Drop Item(hold)", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Map = m_UI.FindAction("Map", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_Inventory = m_UI.FindAction("Inventory", throwIfNotFound: true);
        m_UI_Resume = m_UI.FindAction("Resume", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_UseBlank;
    private readonly InputAction m_Gameplay_Pickup;
    private readonly InputAction m_Gameplay_Reload;
    private readonly InputAction m_Gameplay_NextandPreviousGun;
    private readonly InputAction m_Gameplay_NextandpreviousItem;
    private readonly InputAction m_Gameplay_DropGunhold;
    private readonly InputAction m_Gameplay_DropItemhold;
    public struct GameplayActions
    {
        private @GameMaping m_Wrapper;
        public GameplayActions(@GameMaping wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @UseBlank => m_Wrapper.m_Gameplay_UseBlank;
        public InputAction @Pickup => m_Wrapper.m_Gameplay_Pickup;
        public InputAction @Reload => m_Wrapper.m_Gameplay_Reload;
        public InputAction @NextandPreviousGun => m_Wrapper.m_Gameplay_NextandPreviousGun;
        public InputAction @NextandpreviousItem => m_Wrapper.m_Gameplay_NextandpreviousItem;
        public InputAction @DropGunhold => m_Wrapper.m_Gameplay_DropGunhold;
        public InputAction @DropItemhold => m_Wrapper.m_Gameplay_DropItemhold;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @UseBlank.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseBlank;
                @UseBlank.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseBlank;
                @UseBlank.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUseBlank;
                @Pickup.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickup;
                @Reload.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReload;
                @NextandPreviousGun.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandPreviousGun;
                @NextandPreviousGun.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandPreviousGun;
                @NextandPreviousGun.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandPreviousGun;
                @NextandpreviousItem.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandpreviousItem;
                @NextandpreviousItem.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandpreviousItem;
                @NextandpreviousItem.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNextandpreviousItem;
                @DropGunhold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropGunhold;
                @DropGunhold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropGunhold;
                @DropGunhold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropGunhold;
                @DropItemhold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropItemhold;
                @DropItemhold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropItemhold;
                @DropItemhold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDropItemhold;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @UseBlank.started += instance.OnUseBlank;
                @UseBlank.performed += instance.OnUseBlank;
                @UseBlank.canceled += instance.OnUseBlank;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @NextandPreviousGun.started += instance.OnNextandPreviousGun;
                @NextandPreviousGun.performed += instance.OnNextandPreviousGun;
                @NextandPreviousGun.canceled += instance.OnNextandPreviousGun;
                @NextandpreviousItem.started += instance.OnNextandpreviousItem;
                @NextandpreviousItem.performed += instance.OnNextandpreviousItem;
                @NextandpreviousItem.canceled += instance.OnNextandpreviousItem;
                @DropGunhold.started += instance.OnDropGunhold;
                @DropGunhold.performed += instance.OnDropGunhold;
                @DropGunhold.canceled += instance.OnDropGunhold;
                @DropItemhold.started += instance.OnDropItemhold;
                @DropItemhold.performed += instance.OnDropItemhold;
                @DropItemhold.canceled += instance.OnDropItemhold;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Map;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_Inventory;
    private readonly InputAction m_UI_Resume;
    public struct UIActions
    {
        private @GameMaping m_Wrapper;
        public UIActions(@GameMaping wrapper) { m_Wrapper = wrapper; }
        public InputAction @Map => m_Wrapper.m_UI_Map;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @Inventory => m_Wrapper.m_UI_Inventory;
        public InputAction @Resume => m_Wrapper.m_UI_Resume;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Map.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMap;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Inventory.started -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
                @Resume.started -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnUseBlank(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnNextandPreviousGun(InputAction.CallbackContext context);
        void OnNextandpreviousItem(InputAction.CallbackContext context);
        void OnDropGunhold(InputAction.CallbackContext context);
        void OnDropItemhold(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMap(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
    }
}

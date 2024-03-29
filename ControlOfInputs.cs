//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/ProgramadorRicardo/ControlOfInputs.inputactions
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

public partial class @ControlOfInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlOfInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlOfInputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""80e2f3c7-ad71-4241-816c-bee41c19f9b6"",
            ""actions"": [
                {
                    ""name"": ""Arriba"",
                    ""type"": ""Button"",
                    ""id"": ""6a1b74b6-2612-4170-aa84-73c4c9ee694e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""abajo"",
                    ""type"": ""Button"",
                    ""id"": ""c9920e53-a685-4cec-95f8-36d4731cd8a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Izquierda"",
                    ""type"": ""Button"",
                    ""id"": ""138d98f2-0b9f-4900-ae18-9860b2720fcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Derecha"",
                    ""type"": ""Button"",
                    ""id"": ""77469706-5172-4ef1-92bb-b7e3bb1ce3a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rueda Izqueirda"",
                    ""type"": ""Value"",
                    ""id"": ""98534a5a-d88e-47ac-9dc9-c0227aa28037"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rueda Derecha"",
                    ""type"": ""Value"",
                    ""id"": ""2f78788f-b9d9-48c1-b76e-3f2a7bec03d6"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""2fed596e-9c4c-4f91-8e00-d46d95ae1144"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""e061b09c-74cd-42cf-a5fb-169259f7753c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""0b6b12a5-8242-4fe5-9035-d08f11712152"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""5e7a8f99-6d41-41b5-91c8-2278a418b61f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L3"",
                    ""type"": ""Button"",
                    ""id"": ""d11411ba-0418-4651-bd50-41736162f87f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R3"",
                    ""type"": ""Button"",
                    ""id"": ""ad3a4e72-75b3-4896-880e-dbe51edd45e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""150a8e84-1d77-4264-b785-6d86cf9a5f9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""63e72e16-cb97-48ae-a73e-acd2d64d024e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""b9af50b6-8e65-4b3c-bdb1-086c2fd50c55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""0da41dd9-0b4c-4ff1-b318-c7d2223c5d52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""72f9828c-b1bb-44a6-a43b-2fc2b3141fef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""720db436-fa27-498c-9113-19c01b7748ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""859ae834-2533-485c-95c0-a99d2747c288"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arriba"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""588ef358-bbe4-4c4e-a744-bc265378b117"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rueda Izqueirda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ada81ae-fd5f-4d67-9b0b-62c997dbd712"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rueda Derecha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eda0bf9-b005-4924-8a01-fcfccc5128bc"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Izquierda"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfbf440e-05fc-4d06-9231-23d33f9ca25c"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Derecha"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6dedfa14-4a22-45ea-b922-e5f022d6dee3"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1076008f-ab42-4958-90f6-f6b68a95ed5d"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ea73153-aa01-4ea2-b1b1-651328fa4eb6"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69394bfd-1131-4962-a4ea-9cbe37542e4d"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25099f9d-d638-44f0-adb0-255b4abc3c58"",
                    ""path"": ""<XInputController>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68e22ccf-e53f-45c9-83af-e93e285ff41f"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35697d3f-4924-4021-a839-a225c001a582"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e32b9f5-ea85-4142-b52b-4c7834487758"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9ba6a73-5e00-4390-8b8f-e2e7e8b013f3"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f80733e-4bfa-4427-8dbd-baa5efc64af7"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a37e7021-09b4-4ca7-9780-0761391a2cad"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d92272de-f7ff-4a68-9a45-aab2b7b9cb89"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b3a7d13-d178-4ad3-a508-6097661e1f33"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""abajo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Microntek              USB Joystick          >"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Arriba = m_Gameplay.FindAction("Arriba", throwIfNotFound: true);
        m_Gameplay_abajo = m_Gameplay.FindAction("abajo", throwIfNotFound: true);
        m_Gameplay_Izquierda = m_Gameplay.FindAction("Izquierda", throwIfNotFound: true);
        m_Gameplay_Derecha = m_Gameplay.FindAction("Derecha", throwIfNotFound: true);
        m_Gameplay_RuedaIzqueirda = m_Gameplay.FindAction("Rueda Izqueirda", throwIfNotFound: true);
        m_Gameplay_RuedaDerecha = m_Gameplay.FindAction("Rueda Derecha", throwIfNotFound: true);
        m_Gameplay_L1 = m_Gameplay.FindAction("L1", throwIfNotFound: true);
        m_Gameplay_L2 = m_Gameplay.FindAction("L2", throwIfNotFound: true);
        m_Gameplay_R1 = m_Gameplay.FindAction("R1", throwIfNotFound: true);
        m_Gameplay_R2 = m_Gameplay.FindAction("R2", throwIfNotFound: true);
        m_Gameplay_L3 = m_Gameplay.FindAction("L3", throwIfNotFound: true);
        m_Gameplay_R3 = m_Gameplay.FindAction("R3", throwIfNotFound: true);
        m_Gameplay_A = m_Gameplay.FindAction("A", throwIfNotFound: true);
        m_Gameplay_Y = m_Gameplay.FindAction("Y", throwIfNotFound: true);
        m_Gameplay_X = m_Gameplay.FindAction("X", throwIfNotFound: true);
        m_Gameplay_B = m_Gameplay.FindAction("B", throwIfNotFound: true);
        m_Gameplay_Select = m_Gameplay.FindAction("Select", throwIfNotFound: true);
        m_Gameplay_Start = m_Gameplay.FindAction("Start", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Arriba;
    private readonly InputAction m_Gameplay_abajo;
    private readonly InputAction m_Gameplay_Izquierda;
    private readonly InputAction m_Gameplay_Derecha;
    private readonly InputAction m_Gameplay_RuedaIzqueirda;
    private readonly InputAction m_Gameplay_RuedaDerecha;
    private readonly InputAction m_Gameplay_L1;
    private readonly InputAction m_Gameplay_L2;
    private readonly InputAction m_Gameplay_R1;
    private readonly InputAction m_Gameplay_R2;
    private readonly InputAction m_Gameplay_L3;
    private readonly InputAction m_Gameplay_R3;
    private readonly InputAction m_Gameplay_A;
    private readonly InputAction m_Gameplay_Y;
    private readonly InputAction m_Gameplay_X;
    private readonly InputAction m_Gameplay_B;
    private readonly InputAction m_Gameplay_Select;
    private readonly InputAction m_Gameplay_Start;
    public struct GameplayActions
    {
        private @ControlOfInputs m_Wrapper;
        public GameplayActions(@ControlOfInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Arriba => m_Wrapper.m_Gameplay_Arriba;
        public InputAction @abajo => m_Wrapper.m_Gameplay_abajo;
        public InputAction @Izquierda => m_Wrapper.m_Gameplay_Izquierda;
        public InputAction @Derecha => m_Wrapper.m_Gameplay_Derecha;
        public InputAction @RuedaIzqueirda => m_Wrapper.m_Gameplay_RuedaIzqueirda;
        public InputAction @RuedaDerecha => m_Wrapper.m_Gameplay_RuedaDerecha;
        public InputAction @L1 => m_Wrapper.m_Gameplay_L1;
        public InputAction @L2 => m_Wrapper.m_Gameplay_L2;
        public InputAction @R1 => m_Wrapper.m_Gameplay_R1;
        public InputAction @R2 => m_Wrapper.m_Gameplay_R2;
        public InputAction @L3 => m_Wrapper.m_Gameplay_L3;
        public InputAction @R3 => m_Wrapper.m_Gameplay_R3;
        public InputAction @A => m_Wrapper.m_Gameplay_A;
        public InputAction @Y => m_Wrapper.m_Gameplay_Y;
        public InputAction @X => m_Wrapper.m_Gameplay_X;
        public InputAction @B => m_Wrapper.m_Gameplay_B;
        public InputAction @Select => m_Wrapper.m_Gameplay_Select;
        public InputAction @Start => m_Wrapper.m_Gameplay_Start;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Arriba.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnArriba;
                @Arriba.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnArriba;
                @Arriba.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnArriba;
                @abajo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbajo;
                @abajo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbajo;
                @abajo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAbajo;
                @Izquierda.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @Izquierda.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @Izquierda.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnIzquierda;
                @Derecha.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @Derecha.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @Derecha.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDerecha;
                @RuedaIzqueirda.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaIzqueirda;
                @RuedaIzqueirda.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaIzqueirda;
                @RuedaIzqueirda.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaIzqueirda;
                @RuedaDerecha.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaDerecha;
                @RuedaDerecha.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaDerecha;
                @RuedaDerecha.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRuedaDerecha;
                @L1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL2;
                @R1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR2;
                @L3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL3;
                @L3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL3;
                @L3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnL3;
                @R3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR3;
                @R3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR3;
                @R3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnR3;
                @A.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnA;
                @Y.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnY;
                @X.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnX;
                @B.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnB;
                @Select.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSelect;
                @Start.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Arriba.started += instance.OnArriba;
                @Arriba.performed += instance.OnArriba;
                @Arriba.canceled += instance.OnArriba;
                @abajo.started += instance.OnAbajo;
                @abajo.performed += instance.OnAbajo;
                @abajo.canceled += instance.OnAbajo;
                @Izquierda.started += instance.OnIzquierda;
                @Izquierda.performed += instance.OnIzquierda;
                @Izquierda.canceled += instance.OnIzquierda;
                @Derecha.started += instance.OnDerecha;
                @Derecha.performed += instance.OnDerecha;
                @Derecha.canceled += instance.OnDerecha;
                @RuedaIzqueirda.started += instance.OnRuedaIzqueirda;
                @RuedaIzqueirda.performed += instance.OnRuedaIzqueirda;
                @RuedaIzqueirda.canceled += instance.OnRuedaIzqueirda;
                @RuedaDerecha.started += instance.OnRuedaDerecha;
                @RuedaDerecha.performed += instance.OnRuedaDerecha;
                @RuedaDerecha.canceled += instance.OnRuedaDerecha;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L3.started += instance.OnL3;
                @L3.performed += instance.OnL3;
                @L3.canceled += instance.OnL3;
                @R3.started += instance.OnR3;
                @R3.performed += instance.OnR3;
                @R3.canceled += instance.OnR3;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnArriba(InputAction.CallbackContext context);
        void OnAbajo(InputAction.CallbackContext context);
        void OnIzquierda(InputAction.CallbackContext context);
        void OnDerecha(InputAction.CallbackContext context);
        void OnRuedaIzqueirda(InputAction.CallbackContext context);
        void OnRuedaDerecha(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL3(InputAction.CallbackContext context);
        void OnR3(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}

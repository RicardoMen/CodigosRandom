using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Events;

/**
* Because Unity refused to fix their bugs in Input.*, didn't fix the missing methods in UI.* text-input classes,
* and instead started work on a new InputSystem that still isn't complete and live :).
*
* c.f. https://forum.unity.com/threads/find-out-which-key-was-pressed.385250/
*/
public class CuriousInputs : MonoBehaviour
{
    [Serializable]
    public class KeyCodeEvent : UnityEvent<KeyCode>
    {
    }
    public bool KeyPresed;
    public bool KeyPresed2;
    public bool KeyPresed3;

    public KeyCodeEvent keyDownListener, keyUpListener, keyPressListener;

    private static readonly KeyCode[] keyCodes = Enum.GetValues(typeof(KeyCode))
        .Cast<KeyCode>()
        .Where(k => ((int)k < (int)KeyCode.Mouse0))
        .ToArray();

    private List<KeyCode> _keysDown;

    public void OnEnable()
    {
        _keysDown = new List<KeyCode>();
    }
    public void OnDisable()
    {
        _keysDown = null;
    }

    public void Update()
    {

        for (int i = 0; i < keyCodes.Length; i++)
        {
            KeyCode kc1 = keyCodes[i];
            KeyCode kc2 = keyCodes[i];
            if (Input.GetKey(kc1))
            {
                _keysDown.Add(kc1);
                keyDownListener?.Invoke(kc1);
                Debug.Log(kc1);
                KeyPresed = true;


            }
         



        }

    }
}
        

       

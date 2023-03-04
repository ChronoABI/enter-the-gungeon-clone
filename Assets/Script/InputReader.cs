using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "InputReader")]
public class InputReader : ScriptableObject, GameMaping.IGameplayActions, GameMaping.IUIActions
{
    GameMaping gameMaping;

    private void OnEnable()
    {
        if (gameMaping == null)
        {
            gameMaping = new GameMaping();
            gameMaping.Gameplay.SetCallbacks(this);
            gameMaping.UI.SetCallbacks(this);

            SetGameplay();
        }
    }

    public void SetGameplay()
    {
        gameMaping.Gameplay.Enable();
        gameMaping.UI.Disable();
    }

    public void SetUI()
    {
        gameMaping.Gameplay.Disable();
        gameMaping.UI.Enable();
    }

    public event Action<Vector2> MoveEvent;
    public event Action shootEvent;
    public event Action shootCancelEvent;
    public event Action dashEvent;
    public event Action useBlankEvent;
    public event Action interactEvent;
    public event Action reloadEvent;
    public event Action<float> nextAndPreviousGunEvent;
    public event Action<float> nextAndPreviousItemEvent;
    public event Action dropGunEvent;
    public event Action dropItemEvent;
    public event Action mapUIEvent;
    public event Action pauseEvent;
    public event Action resumeEvent;
    public event Action inventoryUIEvent;

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
        // Debug.Log(message:$"{context.phase}, {context.ReadValue<Vector2>()}");
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            shootEvent?.Invoke();
            // Debug.Log(message:"shooting");
        }

        if (context.phase == InputActionPhase.Canceled)
        {
            shootCancelEvent?.Invoke();
            // Debug.Log(message:"shooting cancled");
        }
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            dashEvent?.Invoke();
        }
    }

    public void OnUseBlank(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            useBlankEvent?.Invoke();
        }
    }

    public void OnPickup(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            interactEvent?.Invoke();
        }
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            reloadEvent?.Invoke();
        }
    }

    public void OnNextandPreviousGun(InputAction.CallbackContext context)
    {
        // float scrollValue = (context.ReadValue<float>() > 0)? 1 : -1;
        nextAndPreviousGunEvent?.Invoke(context.ReadValue<float>());
        Debug.Log(message: $"{context.phase}, {context.ReadValue<float>()}");
    }

    public void OnNextandpreviousItem(InputAction.CallbackContext context)
    {
        float itemValue = (context.ReadValue<float>() > 0) ? 1 : -1;
        nextAndPreviousItemEvent?.Invoke(itemValue);
        // Debug.Log(message:$"{context.phase}, {itemValue}");
    }

    public void OnDropGunhold(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            dropGunEvent?.Invoke();
        }
    }

    public void OnDropItemhold(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            dropItemEvent?.Invoke();
        }
    }

    public void OnMap(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            mapUIEvent?.Invoke();
            SetUI();
        }
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            pauseEvent?.Invoke();
            SetUI();
        }
    }

    public void OnResume(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            resumeEvent?.Invoke();
            SetGameplay();
        }
    }

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            inventoryUIEvent?.Invoke();
            SetUI();
        }
    }
}

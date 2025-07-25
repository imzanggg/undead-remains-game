using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
    public class StarterAssetsInputs : MonoBehaviour
    {
        [Header("Character Input Values")]
        public Vector2 move;
        public Vector2 look;
        public bool jump;
        public bool sprint;

        // Fire-and-forget input flags
        public bool shoot;
        public bool reload;
        public bool grenade;

        [Header("Movement Settings")]
        public bool analogMovement;

        [Header("Mouse Cursor Settings")]
        public bool cursorLocked = true;
        public bool cursorInputForLook = true;

        // Internal reset flags
        private bool _resetShoot;
        private bool _resetReload;
        private bool _resetGrenade;

        public void OnMove(InputValue value)
        {
            MoveInput(value.Get<Vector2>());
        }

        public void OnLook(InputValue value)
        {
            if (cursorInputForLook)
            {
                LookInput(value.Get<Vector2>());
            }
        }

        public void OnJump(InputValue value)
        {
            JumpInput(value.isPressed);
        }

        public void OnSprint(InputValue value)
        {
            SprintInput(value.isPressed);
        }

        public void OnShoot(InputValue value)
        {
            if (value.isPressed)
            {
                shoot = true;
                _resetShoot = true;
            }
        }

        public void OnReload(InputValue value)
        {
            if (value.isPressed)
            {
                reload = true;
                _resetReload = true;
            }
        }

        public void OnGrenade(InputValue value)
        {
            if (value.isPressed)
            {
                grenade = true;
                _resetGrenade = true;
            }
        }

        public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        }

        public void LookInput(Vector2 newLookDirection)
        {
            look = newLookDirection;
        }

        public void JumpInput(bool newJumpState)
        {
            jump = newJumpState;
        }

        public void SprintInput(bool newSprintState)
        {
            sprint = newSprintState;
        }

        private void Update()
        {
            // Reset fire-once inputs
            if (_resetShoot)
            {
                shoot = false;
                _resetShoot = false;
            }

            if (_resetReload)
            {
                reload = false;
                _resetReload = false;
            }

            if (_resetGrenade)
            {
                grenade = false;
                _resetGrenade = false;
            }
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            SetCursorState(cursorLocked);
        }

        private void SetCursorState(bool newState)
        {
            Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
        }
    }
}

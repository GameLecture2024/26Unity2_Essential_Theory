using UnityEngine;
using UnityEngine.InputSystem;

namespace DevTest
{
    public class Player_NewInput : MonoBehaviour
    {
        public PlayerInput playerInput;

        private Vector2 moveInput;

        [SerializeField]
        float moveSpeed = 10.0f;

        public void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();          
        }

        private void Update()
        {
            // transform.position += ( );

            transform.Translate(new Vector3(moveInput.x, 0, moveInput.y) * Time.deltaTime * moveSpeed);
        }
    }
}

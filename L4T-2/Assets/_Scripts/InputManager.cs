using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

namespace UnityTutorial.Manager
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private PlayerInput PlayerInput;
        [SerializeField] private GameObject InventoryPanel;

        public Vector2 Move {get; private set;}
        public Vector2 Look { get; private set;}
        public bool Run { get; private set;}
        public bool Inventory { get; private set;}
        public bool Door { get; private set;}
        public bool Interact { get; private set; }
        public bool MouseLeft { get; private set; }

        private InputActionMap _currentMap;
        private InputAction _moveAction;
        private InputAction _lookAction;
        private InputAction _runAction;
        private InputAction _inventoryAction;
        private InputAction _interactAction;
        private InputAction _mouseLeftAction;

        private void Awake() {      
            _currentMap = PlayerInput.currentActionMap;
            _moveAction = _currentMap.FindAction("Move");
            _lookAction = _currentMap.FindAction("Look");
            _runAction = _currentMap.FindAction("Run");
            _inventoryAction = _currentMap.FindAction("Inventory");
            _interactAction = _currentMap.FindAction("Interact");
            _mouseLeftAction = _currentMap.FindAction("MouseLeft");


            _moveAction.performed += OnMove;
            _lookAction.performed += onLook;
            _runAction.performed += onRun;
            _inventoryAction.performed += onInventory;
            _interactAction.performed += onInteract;
            _mouseLeftAction.performed += onMouseLeft;


            _moveAction.canceled += OnMove;
            _lookAction.canceled += onLook;
            _runAction.canceled += onRun;
            _inventoryAction.canceled += onInventory;
            _interactAction.canceled += onInteract;
            _mouseLeftAction.canceled += onMouseLeft;
        }

        public void HideCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            if (Inventory) Inventory = false;
        }
        public void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

       private void OnMove(InputAction.CallbackContext context)
        {
            Move = context.ReadValue<Vector2>();
        }
        private void onLook(InputAction.CallbackContext context)
        {
            Look = context.ReadValue<Vector2>();
        }
        private void onRun(InputAction.CallbackContext context)
        {
            Run = context.ReadValueAsButton(); 
        }
        private void onInventory(InputAction.CallbackContext context)
        {
            Inventory = context.ReadValueAsButton() ? !Inventory : Inventory;          
        }
        private void onInteract(InputAction.CallbackContext context)
        {
            Interact = context.ReadValueAsButton();
        }
        private void onMouseLeft(InputAction.CallbackContext context)
        {
            MouseLeft = context.ReadValueAsButton();
        }
        private void OnEnable() {
            _currentMap.Enable();
       }

        private void OnDisable() {
            _currentMap.Disable(); 
        }

    }
}



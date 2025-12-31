using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCellTouch : MonoBehaviour
{
    private Touch touch;
    private Quaternion rotationY;
    private float rotateSpeed = 0.2f;

    public InputAction rotateAction;
    private void OnEnable()
    {
        rotateAction.Enable();
        rotateAction.performed += OnRotatePerformed;
    }
    private void OnDisable()
    {
        rotateAction.Disable();
        rotateAction.performed -= OnRotatePerformed;
    }
    void OnRotatePerformed(InputAction.CallbackContext context)
    {
        Vector2 delta = context.ReadValue<Vector2>();

        if(delta.x !=0)
        {
            Quaternion rotationY = Quaternion.Euler(0f, -delta.x * rotateSpeed, 0f);
            transform.rotation = rotationY * transform.rotation; 
        }
    }
}

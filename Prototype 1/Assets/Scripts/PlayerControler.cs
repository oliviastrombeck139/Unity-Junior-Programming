using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    //Movement tuning (editable in inspector)
    public float speed = 10.0f;
    public float turnSpeed;
    // Input system action esposed in inspector for binding (WASD/arrow keys)
    public InputAction moveAction;
    // Current input value (x = left/right, y = forward/back), kept private for internal use
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the moveAction so it starts reading input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward

        // Moves vehicle forward/back along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate around local Y (yaw) using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

        moveInput = moveAction.ReadValue<Vector2>();
    }
}

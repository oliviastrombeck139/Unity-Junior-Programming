using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed;
    public InputAction moveAction;
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        moveInput = moveAction.ReadValue<Vector2>();
    }
}

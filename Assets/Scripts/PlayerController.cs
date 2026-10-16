using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 1000f;

    private InputSystem_Actions controls;

    private Rigidbody playerRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        controls = new InputSystem_Actions();
        playerRb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveInput = controls.Player.Move.ReadValue<Vector2>();
        float forwardInput = moveInput.y;
        float sidewardInput = moveInput.x;


        playerRb.AddForce(Vector3.forward * forwardInput * playerSpeed * Time.deltaTime);
        playerRb.AddForce(Vector3.right * sidewardInput * playerSpeed * Time.deltaTime);
    }
}

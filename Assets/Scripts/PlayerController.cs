using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 8f;
    public InputActionReference moveInput;
    // Start is called before the first frame update
    void Start()
    {
        this.moveInput.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        this.rb.velocity = this.moveInput.action.ReadValue<Vector2>() * this.moveSpeed;
        Debug.Log(this.moveInput.action.ReadValue<Vector2>());

    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 8f;
    public InputActionReference moveInput;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.moveInput.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        this.rb.velocity = this.moveInput.action.ReadValue<Vector2>().normalized * this.moveSpeed;
        this.animator.SetFloat("speed", this.rb.velocity.magnitude);
        if (this.rb.velocity.x > 0) {
            this.transform.localScale = new Vector3(1, 1, 1);
        } else if (this.rb.velocity.x < 0) {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}

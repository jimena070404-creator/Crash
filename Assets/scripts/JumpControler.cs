using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;

public class JumpControler : MonoBehaviour
{
    [SerializeField]
    private InputController inputController;
    [SerializeField]
    private CharacterController characterController;
    [SerializeField]
    private UnityEvent onJump;
    [SerializeField]
    private float jumpVelocity = 8f;
    [SerializeField]
    private float gravity = -15f;
    private float verticalVelocity;
    private bool hasGravity = true;
    public bool HasGravity
    {
        set
        {
            hasGravity = value;
            if (!hasGravity)
            {
                verticalVelocity = 0f;
            }
        }
    }
    public float VerticalVelocity => verticalVelocity;
    private void Update() 
    {
        if (characterController.isGrounded)
        {
            if (verticalVelocity < 0f)
            {
                verticalVelocity = -2f;
            }
            if (inputController.Jump)
            {
                Jump();
            }
        }
        else
        {
            if (hasGravity)
            {
                verticalVelocity+= gravity * Time.deltaTime;
            }
        }
    }
    public void Jump()
    {
        onJump.Invoke();
        verticalVelocity = jumpVelocity;
    }
}

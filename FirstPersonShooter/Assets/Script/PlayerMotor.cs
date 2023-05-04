using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero; 
    private Rigidbody rb ; 
    private Vector3 rotation = Vector3.zero ; 
    private void Start() 
    {
        rb = GetComponent<Rigidbody>();  
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity ; 
    }
//  takes in normal rotation Vector 
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation ; 
    }

    // run every physics iterations 
    private void FixedUpdate() 
    {
        PerformMovement() ; 
        PerformRotation();
    }
    // performs the movement based on velocity variable 
    void PerformMovement() 
    {
        if( velocity != Vector3.zero)
        {
        rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
        }
    }
    // performs the Rotation based on Rotation variable 
    void PerformRotation() 
    {
        rb.MoveRotation(rb.rotation*Quaternion.Euler(rotation));
    }

}

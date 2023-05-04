using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f ; 

    [SerializeField] 
    private float lookSensitivity = 3f ; 

    private PlayerMotor motor ; 

    private void Start()
    {
        // no error handling is required 
        // as we have marked it Player motor required on this Component 
        motor = GetComponent<PlayerMotor>() ; 
    }

    private void Update() 
    {
        // Calculate the movement velocity as a 3D vector 
        float _xMov = Input.GetAxisRaw("Horizontal");
        // xMov would Return values between 1 and -1 
        // we can use it for direction 
        float _zMov = Input.GetAxisRaw("Vertical");
        // zMov would Return values between 1 and -1 
        // we can use it for direction 

        
        Vector3 moveHorizontal = transform.right * _zMov * -1 ; 
        Vector3 moveVertical = transform.forward * _xMov ; 

        
        // Vector3 velocity = new Vector3(_xMov,0.0f,_zMov).normalized * speed ; 

        // how the Vectors are Being Added ? 
        // (1x,2y,3z) + (3x,3y,1z) = (4x,5y,4z) 
        Vector3 velocity = (moveHorizontal+moveVertical).normalized * speed ; 

        

        // final movement 

        motor.Move(velocity); 
        // calculate rotaton as 3d Vector 
        // {turning around}

        float yRot = Input.GetAxisRaw("Mouse X") ; 
        Vector3 _rotation = new Vector3(0f,yRot,0f) * lookSensitivity;

        // we have rotated the object along y axis so , that it can move 
        // in xz plane 

        // Apply Rotation 
        motor.Rotate(_rotation); 

        
    }
}

/*
GetAxis is smoothed based on the “sensitivity” setting
so that value gradually changes from 0 to 1, or 0 to -1. 
Whereas GetAxisRaw will only ever return 0, -1, or 1 exactly 
(assuming a digital input such as a keyboard or joystick button).
*/

/*
----------notes-----------
Transform.right moves the GameObject while also considering its rotation. 
When a GameObject is rotated, the red arrow representing the X axis of the 
GameObject also changes direction
........................................................
transform.right is a vector facing the world right (Scene's right). It will always be (1, 0, 0)
.......................................................
Vector3.right is a vector facing the local-space right {player's right } , 
meaning it is a vector that faces to the right of your object.
*/

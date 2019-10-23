using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigidBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal"); //Declara la variable y le asigna el valor del eje horizontal
        Debug.Log(movementHorizontal); //muestra en la ventana de comandos el valor 
        float movementVertical = Input.GetAxis("Vertical");
        Debug.Log(movementVertical);

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);
        myRigidBody.AddForce(speed * movement);
        
    }
}

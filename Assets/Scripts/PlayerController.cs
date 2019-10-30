using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigidBody;
    public float speed;
    int score=0;

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
         
        float movementVertical = Input.GetAxis("Vertical");
        

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);
        myRigidBody.AddForce(speed * movement);
        
    }

    private void OnTriggerEnter(Collider other)  // para los objetos que tengan triger pasa lo de abajo cuando lo atravesamos
    {
        if (other.gameObject.CompareTag("PickUp")) //para que solo pase el tema de desaparecer con los objetos que tengan el tag que le he concretado
        {
            other.gameObject.SetActive(false);  //hace que desaparezca el objeto cuando colisiona si tiene trigger

            score ++;

            score += other.gameObject.GetComponent<Pickupcoin>().points;

            Debug.Log("Mi puntuacion es : " + score);

        }
    }
}

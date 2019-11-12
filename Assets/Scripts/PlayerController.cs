using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigidBody;
    public float speed;
    public float jump;
    public Text scoreText;
    public bool Grounded;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!!!");
        scoreText.text = "SCORE :" + 0;
    }


    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal"); //Declara la variable y le asigna el valor del eje horizontal
         
        float movementVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
            jump = 30.3f;
        else
            jump = 0;

        Vector3 movement = new Vector3(movementHorizontal, jump, movementVertical);

        myRigidBody.AddForce(speed * movement);
        
    }

    private void OnTriggerEnter(Collider other)  // para los objetos que tengan triger, pasa lo de abajo cuando lo atravesamos
    {
        if (other.gameObject.CompareTag("PickUp")) //para que solo pase el tema de desaparecer con los objetos que tengan el tag que le he concretado
        {
            other.gameObject.SetActive(false);  //hace que desaparezca el objeto cuando colisiona si tiene trigger   , si es un pick up, lo desactivo.


            score += other.gameObject.GetComponent<Pickupcoin>().points;

            

            scoreText.text = "SCORE :" + score;

        }

        if (other.gameObject.CompareTag("Escenario"))
        {
            Grounded = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Escenario"))
        {
            Grounded = false;
        }
    }
}

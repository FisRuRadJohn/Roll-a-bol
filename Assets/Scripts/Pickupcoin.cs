using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupcoin : MonoBehaviour
{
    public int points;
    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(30, 40, 45) * Time.deltaTime;
        transform.Rotate(rotation);
    } 
}

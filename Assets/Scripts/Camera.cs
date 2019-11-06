using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject target;

    Vector3 offset;

  
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

   
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}

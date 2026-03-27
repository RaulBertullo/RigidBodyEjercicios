using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 direccion = Vector3.zero;

        
        if (Input.GetKey(KeyCode.W))
            direccion += transform.forward;
        if (Input.GetKey(KeyCode.S))
            direccion -= transform.forward;
        if (Input.GetKey(KeyCode.D))
            direccion += transform.right;
        if (Input.GetKey(KeyCode.A))
            direccion -= transform.right;

        
        if (direccion != Vector3.zero)
        {
            direccion = direccion.normalized;
        }

        
        rb.linearVelocity = direccion * velocidad;
    }
}

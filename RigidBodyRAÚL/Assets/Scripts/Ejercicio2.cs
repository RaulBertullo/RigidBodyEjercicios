using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direccion += transform.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direccion -= transform.forward;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direccion += transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direccion -= transform.right;
        }

        if (direccion != Vector3.zero)
        {
            rb.AddForce(direccion * fuerza, ForceMode.Force);
        }
    }
}

using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public float torqueFuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float giro = 0f;

        // Input: flechas izquierda/derecha
        if (Input.GetKey(KeyCode.LeftArrow))
            giro = -1f;
        if (Input.GetKey(KeyCode.RightArrow))
            giro = 1f;

        if (giro != 0f)
        {
            
            rb.AddTorque(Vector3.up * giro * torqueFuerza, ForceMode.Force);
        }
    }
}

using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] private float fuerza = 10.0f;
        private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            rb.AddForce(transform.forward * fuerza, ForceMode.Force);
            Debug.Log("me muevo");

        }
    }
}

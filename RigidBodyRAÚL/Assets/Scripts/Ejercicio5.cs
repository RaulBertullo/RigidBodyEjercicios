using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    [SerializeField] private float fuerzaSalto = 5.0f;
    private bool enSuelo = true;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            enSuelo = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        enSuelo = true;
    }
}

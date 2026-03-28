using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public float explosionForce = 500f;
    public float explosionRadius = 5f;
    public float upwardsModifier = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 explosionPos = transform.position;

            Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);


            for (int i = 0; i < colliders.Length; i++)
            {
                Rigidbody rb = colliders[i].GetComponent<Rigidbody>();

                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce, explosionPos, explosionRadius, upwardsModifier, ForceMode.Impulse);
                }
            }
        }
    }
}

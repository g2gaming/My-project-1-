using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector3 force;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnMove(InputValue movementInput)
    {
        Debug.Log(movementInput.Get<Vector2>());
        force = movementInput.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(force.x, 0, force.y);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }
    }
}

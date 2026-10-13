using UnityEngine;

public class CharacterMovement : MonoBehaviour

{

    public float maxSpeed = 6.0f;
    public float Direccion;
    public bool fancyRigth = true;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        Direccion = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(Direccion * maxSpeed, rb.linearVelocity.y, 0f);
    }
}

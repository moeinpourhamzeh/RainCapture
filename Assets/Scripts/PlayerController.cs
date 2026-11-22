using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _horizontalInput = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Debug.Log("PlayerController Start");
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");

        
         if (_horizontalInput != 0)
        {
            _rb.AddForce(new Vector2(_horizontalInput * 5f, 0f));
        }
    }
}

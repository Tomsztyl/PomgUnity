using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            _rigidbody2D.velocity = new Vector2(0f, 7f);
        }
        else if (Input.GetKey(down))
        {
            _rigidbody2D.velocity = new Vector2(0f, -7f);
        }
        else
        {
            _rigidbody2D.velocity = new Vector2(0, 0);
        }
    }
}

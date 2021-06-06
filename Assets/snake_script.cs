using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class snake_script : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && _direction.)
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;
        }
    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );
    }
}

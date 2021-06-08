using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SnakeScript: MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    private List<GameObject> _snakeBody = new List<GameObject>();

    public GameObject SnakeBodyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && _direction.y != -1.0f)
        {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.A) && _direction.x != 1.0f)
        {
            _direction = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.S) && _direction.y != 1.0f)
        {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.D) && _direction.x != -1.0f)
        {
            _direction = Vector2.right;
        }
    }

    void FixedUpdate()
    {
        //move each snakebody to the 
        this.transform.position = new Vector3(
            (Mathf.Round(this.transform.position.x) + _direction.x),
            (Mathf.Round(this.transform.position.y) + _direction.y),
            0.0f
        );
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Entered");
        
        if (col.tag == "Pellet") // if pellet add snake
        {
            addNewSegment();

            // create new pellet

        } else if (col.tag == "snake" || col.tag == "wall") // if wall or self destroy
        {

        }
    }

    void addNewSegment()
    {
        // add new Gameobject to _snakebody list at last position
        _snakeBody.Add(Instantiate(
            SnakeBodyPrefab,
            this.transform.position,
            Quaternion.identity
        ));

        Debug.Log(_snakeBody);
    }
}

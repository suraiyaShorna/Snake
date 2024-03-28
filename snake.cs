using UnityEngine;

public class snake : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }

    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y, 0.0f);
    }
}

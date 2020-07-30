using System.Collections;
using UnityEngine;

public class player : MonoBehaviour
{

    private float speed = 15f;
    private Rigidbody2D rb;
    private float mapwidth = 4f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float c = Input.GetAxis("Horizontal");
        Vector3 coor = Vector3.right * c;
        Move(coor);
    }

    public void Move (Vector3 coord)
    {

        float x = coord.x * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapwidth, mapwidth);
        rb.MovePosition(newPosition);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().endgame();

    }
}

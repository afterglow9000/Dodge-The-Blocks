using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mapWidth = 5f;
    public Rigidbody2D rB;
    public float speed = 15f;

	private void FixedUpdate ()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rB.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rB.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D ()
    {
        FindObjectOfType<GamingManager>().EndGame();
    }

    private void Start ()
    {
        rB = GetComponent<Rigidbody2D>();
    }
}

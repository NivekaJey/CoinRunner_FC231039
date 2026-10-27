using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (transform.position.y < -10f)
        {
            Respawn();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.instance.AddCoin();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Goal"))
        {
            GameManager.instance.LevelComplete();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = startPos;
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
    }
}
using Unity.Cinemachine;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float bulletSpeed = 20f;
    [SerializeField] int BasicEnemy = 50;
    [SerializeField] int HardEnemy = 100;
    Rigidbody2D myRigidBody;
    PlayerMovement player;
    float xSpeed;
    bool isHit = false;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindAnyObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
        myRigidBody.linearVelocity = new Vector2(xSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(isHit == true)
        {
            return;
        }
        if(other.CompareTag("Enemy1"))
        {
            isHit = true;
            Destroy(other.gameObject);
            Debug.Log("Hit Enemy");
            FindAnyObjectByType<GameSession>().AddToScore(HardEnemy);
        }
        if (other.CompareTag("Enemy2"))
        {
            isHit = true;
            Destroy(other.gameObject);
            Debug.Log("Hit Enemy");
            FindAnyObjectByType<GameSession>().AddToScore(BasicEnemy);
        }
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0.1f);
    }
}

using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidBody.linearVelocity = new Vector2(moveSpeed, 0f);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moveSpeed = -moveSpeed;
        flipEnemy();
    }

    void flipEnemy()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.linearVelocity.x)), 1f);
    }
}

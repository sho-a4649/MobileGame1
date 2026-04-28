using UnityEngine;
using UnityEngine.SceneManagement;

public class BallReset : MonoBehaviour
{
    public float resetY = -5f;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (transform.position.y < resetY)
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        // ë¨ìxÇé~ÇﬂÇÈ
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // èâä˙à íuÇ÷ñﬂÇ∑
        transform.position = startPos;
    }
}

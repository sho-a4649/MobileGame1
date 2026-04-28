using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionBall : MonoBehaviour
{
    public float frictionStrength = 0.5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // ‚Ù‚ÚŽ~‚Ü‚Á‚Ä‚¢‚½‚ç‰½‚à‚µ‚È‚¢
        if (rb.velocity.sqrMagnitude < 0.001f)
            return;

        // ‘¬“x‚Ì‹tŒü‚«‚ÉŒ¸‘¬—Í‚ð‚©‚¯‚é
        Vector3 frictionForce = -rb.velocity.normalized * frictionStrength;
        rb.AddForce(frictionForce, ForceMode.Acceleration);
    }
}

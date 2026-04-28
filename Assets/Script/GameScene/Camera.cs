using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // ƒ{[ƒ‹
    public float followSpeed = 5f;

    private Vector3 offset;

    private void Start()
    {
        // Å‰‚Ì‘Š‘ÎˆÊ’u‚ğ•Û‘¶
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        // x‚¾‚¯ˆÚ“®
        Vector3 targetPos = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);

        // ŠŠ‚ç‚©‚ÉˆÚ“®
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * followSpeed);
    }
}

using UnityEngine;

public class Stage : MonoBehaviour
{
    public float tiltPower = 0.15f;
    public float maxTilt = 10f;
    public float smoothSpeed = 6f;

    public bool canControl = true; // ÉSÅ[Éãå„í‚é~

    private Vector2 startTouch;
    private Quaternion targetRotation;

    private void Start()
    {
        targetRotation = transform.rotation;
    }

    private void Update()
    {
        if (!canControl) return;

        if (Input.GetMouseButtonDown(0))
        {
            startTouch = Input.mousePosition;
        }

        /*if (Input.GetMouseButton(0))
        {
            Vector2 currentTouch = Input.mousePosition;
            Vector2 delta = currentTouch - startTouch;

            float tiltX = Mathf.Clamp(-delta.y * tiltPower, -maxTilt, maxTilt);
            float tiltZ = Mathf.Clamp(delta.x * tiltPower, -maxTilt, maxTilt);

            transform.rotation = Quaternion.Euler(tiltX, 0, tiltZ);
        }*/
        if (Input.GetMouseButton(0))
        {
            Vector2 delta = (Vector2)Input.mousePosition - startTouch;

            float tiltX = Mathf.Clamp(-delta.y * tiltPower, -maxTilt, maxTilt);
            float tiltZ = Mathf.Clamp(delta.x * tiltPower, -maxTilt, maxTilt);

            // íºê⁄âÒÇ≥Ç»Ç¢
            targetRotation = Quaternion.Euler(tiltX, 0f, tiltZ);
        }
        else
        {
            // ñ≥ëÄçÏÇ≈êÖïΩÇ÷ñﬂÇ∑
            targetRotation = Quaternion.identity;
        }
        // âÒì]ÇääÇÁÇ©Ç…
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * smoothSpeed);
    }
}

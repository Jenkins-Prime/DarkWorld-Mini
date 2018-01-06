using UnityEngine;

public class AntiGrav : MonoBehaviour
{
    private float originalGravScale;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Projectile"))
        {
            originalGravScale = other.attachedRigidbody.gravityScale;
            other.attachedRigidbody.gravityScale = -2;
            if (enabled == false)
            {
                other.attachedRigidbody.gravityScale = originalGravScale;
            }
        }
        else
        {
            return;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.attachedRigidbody.gravityScale = 1;
    }
}
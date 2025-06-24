using UnityEngine;

public class HintEffect : MonoBehaviour
{
    public float duration = 6f;
    private float timer;

    private Vector3 originalScale;
    public float pulseSpeed = 2f;
    public float pulseAmount = 0.1f;

    void Start()
    {
        timer = duration;
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Pulse animation
        float scale = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = originalScale * scale;

        // Countdown to destroy
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}

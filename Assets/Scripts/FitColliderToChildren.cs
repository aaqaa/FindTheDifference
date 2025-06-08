using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FitColliderToChildren : MonoBehaviour
{
    void Start()
    {
        ResizeCollider();
    }

    public void ResizeCollider()
    {
        Bounds combinedBounds = new Bounds(transform.position, Vector3.zero);
        bool hasBounds = false;

        foreach (Renderer childRenderer in GetComponentsInChildren<Renderer>())
        {
            if (!hasBounds)
            {
                combinedBounds = childRenderer.bounds;
                hasBounds = true;
            }
            else
            {
                combinedBounds.Encapsulate(childRenderer.bounds);
            }
        }

        if (hasBounds)
        {
            BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
            Vector2 size = combinedBounds.size;
            Vector2 center = combinedBounds.center - (Vector3)transform.position;

            boxCollider.offset = center;
            boxCollider.size = size;
        }
    }
}

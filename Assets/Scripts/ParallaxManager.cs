using UnityEngine;
using UnityEngine.UI;

public class ParallaxUI : MonoBehaviour
{
    [System.Serializable]
    public class ParallaxLayer
    {
        public RectTransform layer;
        public float parallaxFactor = 0.5f;
        public bool shouldRepeat = true;
        [HideInInspector] public RectTransform duplicateLayer;
        [HideInInspector] public Vector2 initialPosition;
        [HideInInspector] public float layerHeight;
    }

    public ScrollRect scrollRect;
    public ParallaxLayer[] parallaxLayers;
    public Transform backgroundContainer;
    
    private Vector2 lastContentPos;

    void Start()
    {
        if (scrollRect == null || scrollRect.content == null)
        {
            Debug.LogError("ScrollRect or Content not assigned.");
            enabled = false;
            return;
        }

        // Create background container if not assigned
        if (backgroundContainer == null)
        {
            GameObject container = new GameObject("ParallaxBackground");
            container.transform.SetParent(scrollRect.transform, false);
            container.transform.SetAsFirstSibling();
            backgroundContainer = container.transform;
        }

        lastContentPos = scrollRect.content.anchoredPosition;

        // Initialize layers
        for (int i = 0; i < parallaxLayers.Length; i++)
        {
            if (parallaxLayers[i].layer == null)
            {
                Debug.LogError($"Layer {i} is not assigned!");
                continue;
            }

            // Store initial position and height
            parallaxLayers[i].initialPosition = parallaxLayers[i].layer.anchoredPosition;
            parallaxLayers[i].layerHeight = parallaxLayers[i].layer.rect.height;

            // Move to background container
            parallaxLayers[i].layer.SetParent(backgroundContainer, false);
            parallaxLayers[i].layer.anchoredPosition = parallaxLayers[i].initialPosition;

            if (parallaxLayers[i].shouldRepeat)
            {
                CreateDuplicateLayer(i);
            }
        }
    }

   void CreateDuplicateLayer(int index)
{
    if (parallaxLayers[index].duplicateLayer != null)
    {
        Destroy(parallaxLayers[index].duplicateLayer.gameObject);
    }

    // Create duplicate
    GameObject duplicate = Instantiate(parallaxLayers[index].layer.gameObject, backgroundContainer);
    duplicate.name = parallaxLayers[index].layer.name + "_Duplicate";
    parallaxLayers[index].duplicateLayer = duplicate.GetComponent<RectTransform>();

    // Copy color and material
    Image originalImage = parallaxLayers[index].layer.GetComponent<Image>();
    Image duplicateImage = duplicate.GetComponent<Image>();
    if (originalImage != null && duplicateImage != null)
    {
        duplicateImage.color = originalImage.color;
        duplicateImage.material = originalImage.material;
    }

    // Position duplicate
    Vector2 dupPos = parallaxLayers[index].initialPosition;
    dupPos.y += parallaxLayers[index].layerHeight;
    parallaxLayers[index].duplicateLayer.anchoredPosition = dupPos;

    // Maintain visual order — insert duplicate just before the original
    int originalIndex = parallaxLayers[index].layer.GetSiblingIndex();
    parallaxLayers[index].duplicateLayer.SetSiblingIndex(originalIndex);
}


    void LateUpdate()
    {
        if (scrollRect.content == null) return;

        Vector2 delta = scrollRect.content.anchoredPosition - lastContentPos;

        for (int i = 0; i < parallaxLayers.Length; i++)
        {
            if (parallaxLayers[i].layer == null) continue;

            // Apply parallax movement
            MoveLayer(parallaxLayers[i].layer, delta.y * parallaxLayers[i].parallaxFactor);
            
            if (parallaxLayers[i].shouldRepeat)
            {
                if (parallaxLayers[i].duplicateLayer == null)
                {
                    CreateDuplicateLayer(i);
                }
                else
                {
                    MoveLayer(parallaxLayers[i].duplicateLayer, delta.y * parallaxLayers[i].parallaxFactor);
                }
                
                WrapLayer(i);
            }
        }

        lastContentPos = scrollRect.content.anchoredPosition;
    }

    void MoveLayer(RectTransform layer, float deltaY)
    {
        if (layer == null) return;
        
        Vector2 pos = layer.anchoredPosition;
        pos.y += deltaY;
        layer.anchoredPosition = pos;
    }

    void WrapLayer(int layerIndex)
    {
        if (parallaxLayers[layerIndex].duplicateLayer == null) return;

        RectTransform layer = parallaxLayers[layerIndex].layer;
        RectTransform duplicate = parallaxLayers[layerIndex].duplicateLayer;
        float height = parallaxLayers[layerIndex].layerHeight;
        Vector2 initialPos = parallaxLayers[layerIndex].initialPosition;

        // Calculate vertical thresholds
        float lowerThreshold = initialPos.y - height;
        float upperThreshold = initialPos.y + height;

        // Wrap main layer if needed
        if (layer.anchoredPosition.y <= lowerThreshold)
        {
            layer.anchoredPosition = new Vector2(
                layer.anchoredPosition.x,
                duplicate.anchoredPosition.y + height
            );
        }
        else if (layer.anchoredPosition.y >= upperThreshold)
        {
            layer.anchoredPosition = new Vector2(
                layer.anchoredPosition.x,
                duplicate.anchoredPosition.y - height
            );
        }

        // Wrap duplicate layer if needed
        if (duplicate.anchoredPosition.y <= lowerThreshold)
        {
            duplicate.anchoredPosition = new Vector2(
                duplicate.anchoredPosition.x,
                layer.anchoredPosition.y + height
            );
        }
        else if (duplicate.anchoredPosition.y >= upperThreshold)
        {
            duplicate.anchoredPosition = new Vector2(
                duplicate.anchoredPosition.x,
                layer.anchoredPosition.y - height
            );
        }
    }
}
    using UnityEngine;

    public class ClickDetector : MonoBehaviour
    {
        public LayerMask diffSpotLayer; // assign this to 'DiffCircleLayer' in Inspector
        public GameObject crossPrefab;

        private float clickCooldown = 0.25f; // Reduce cooldown for better UX
        private float lastClickTime = -1f;

        private Camera mainCamera;
        public Collider2D imageCollider; // Assign the image's collider in Inspector

        //  Collider2D imageCollider2; // Assign the image's collider in Inspector


        void Start()
        {
            mainCamera = Camera.main;
        }

        void Update()
        {
            if (Time.time - lastClickTime < clickCooldown)
            return;

            if(LevelController.disableImageClick)
            return;

            if (Input.GetMouseButtonDown(0) && !IsPointerOverUI())
            {
                            lastClickTime = Time.time; // ✅ Make sure to update this here!

        
                Vector2 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
                // if (imageCollider != null && imageCollider.OverlapPoint(mousePos) ){ 
                // (imageCollider2 != null && imageCollider2.OverlapPoint(mousePos))){

                

                // Only detect hits on DiffCircleLayer
                RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity, diffSpotLayer);

                if (hit.collider != null)
                {   

                    Debug.Log("✅ Clicked on correct diff spot: " + hit.collider.name);
                    // Optional: You can do something here
                }
                else if (imageCollider != null && imageCollider.OverlapPoint(mousePos))
                {
                    Debug.Log("❌ Clicked on wrong spot.");
                    ShowCrossAt(mousePos);
                    Handheld.Vibrate();
                    HealthManager.Instance.RegisterWrongClick();

                }
            // }
            }
        }

        void ShowCrossAt(Vector2 position)
        {
            if (crossPrefab != null)
            {
                Instantiate(crossPrefab, position, Quaternion.identity);
            }
        }
    bool IsPointerOverUI()
        {
    #if UNITY_EDITOR || UNITY_STANDALONE
            return UnityEngine.EventSystems.EventSystem.current != null &&
                UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
    #else
            if (Input.touchCount > 0)
                return UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId);
            return false;
    #endif
        }   
    }

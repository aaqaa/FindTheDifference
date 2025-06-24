    using System.Collections;
    using System.IO;
    using UnityEngine;
    using UnityEngine.AddressableAssets;
    using UnityEngine.ResourceManagement.AsyncOperations;
    using UnityEngine.UI;

    public class ImageCacheManager : MonoBehaviour
    {
        public static ImageCacheManager Instance;
        public GameObject loadingScreen; // Assign a loading screen UI GameObject in the inspector
        public GameObject noInternetScreen;
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        // public void LoadImage(string spriteKey, SpriteRenderer targetRenderer)
        // {
        //     StartCoroutine(LoadSpriteCoroutine(spriteKey, targetRenderer));
        // }
            public void LoadImage(string spriteKey, SpriteRenderer targetRenderer)
        {
            StartCoroutine(LoadSpriteCoroutine(spriteKey, (Sprite sprite) =>
            {
                if (targetRenderer != null)
                    targetRenderer.sprite = sprite;
            }));
        }
    public void LoadImage(string spriteKey, Image targetImage)
        {
            StartCoroutine(LoadSpriteCoroutine(spriteKey, (Sprite sprite) =>
            {
                if (targetImage != null)
                    targetImage.sprite = sprite;
            }));
        }
    private IEnumerator LoadSpriteCoroutine(string spriteKey, System.Action<Sprite> onSpriteLoaded)
    {
            loadingScreen.SetActive(true);
        string filePath = Path.Combine(Application.persistentDataPath, spriteKey + ".jpg");

        if (File.Exists(filePath))
        {
            byte[] data = File.ReadAllBytes(filePath);
            Texture2D texture = new Texture2D(2, 2);
            texture.LoadImage(data);

            Sprite cachedSprite = Sprite.Create(texture,
                new Rect(0, 0, texture.width, texture.height),
                new Vector2(0.5f, 0.5f));
            onSpriteLoaded?.Invoke(cachedSprite);
            loadingScreen.SetActive(false);
            yield break;
        }

        // Load from Addressables
        AsyncOperationHandle<Sprite> handle = Addressables.LoadAssetAsync<Sprite>(spriteKey);
        yield return handle;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {   noInternetScreen.SetActive(false);  
            Sprite sprite = handle.Result;
            onSpriteLoaded?.Invoke(sprite);

            // Cache as PNG
            // Texture2D texture = sprite.texture;
            // byte[] jpgData = texture.EncodeToJPG();

            Texture2D original = sprite.texture;
            Texture2D readableTex = new Texture2D(original.width, original.height, TextureFormat.RGB24, false);
            readableTex.SetPixels(original.GetPixels());
            readableTex.Apply();

            byte[] jpgData = readableTex.EncodeToJPG();
            Object.Destroy(readableTex); // cleanup


            File.WriteAllBytes(filePath, jpgData);
        }
        else
        {
            noInternetScreen.SetActive(true);
            Debug.LogError("Failed to load sprite from Addressables: " + spriteKey);
        }
            loadingScreen.SetActive(false);
        }
        // private IEnumerator LoadSpriteCoroutine(string spriteKey, SpriteRenderer targetRenderer)
        // {
        //     string filePath = Path.Combine(Application.persistentDataPath, spriteKey + ".png");

        //     if (File.Exists(filePath))
        //     {
        //         byte[] data = File.ReadAllBytes(filePath);
        //         Texture2D texture = new Texture2D(2, 2);
        //         texture.LoadImage(data);

        //         Sprite cachedSprite = Sprite.Create(texture,
        //             new Rect(0, 0, texture.width, texture.height),
        //             new Vector2(0.5f, 0.5f));
        //         targetRenderer.sprite = cachedSprite;

        //         yield break;
        //     }

        //     // Load from Addressables as Sprite
        //     AsyncOperationHandle<Sprite> handle = Addressables.LoadAssetAsync<Sprite>(spriteKey);
        //     yield return handle;

        //     if (handle.Status == AsyncOperationStatus.Succeeded)
        //     {
        //         Sprite sprite = handle.Result;
        //         targetRenderer.sprite = sprite;

        //         // Cache the sprite's texture locally as PNG
        //         Texture2D texture = sprite.texture;
        //         byte[] pngData = texture.EncodeToPNG();
        //         File.WriteAllBytes(filePath, pngData);
        //     }
        //     else
        //     {
        //         Debug.LogError("Failed to load sprite from Addressables: " + spriteKey);
        //     }
        // }
    }

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

// Manages game state, levels, and logic
public class GameManager : MonoBehaviour
{
    // public static GameManager Instance { get; private set; }

    // [Tooltip("Total number of levels in the game (e.g. 10).")]
    // public int totalLevels = 10;
    // [Tooltip("Number of hints available per level by default.")]
    // public int hintsPerLevel = 3;

    // [System.Serializable]
    // public class LevelData {
    //     public Sprite leftImage;                   // Placeholder left image for level
    //     public Sprite rightImage;                  // Placeholder right image for level
    //     public Vector2[] differencePositions;      // Positions of the 5 differences (set in editor, see instructions)
    // }
    // public LevelData[] levels;                     // Array of level data (size = totalLevels)

    // [HideInInspector] public int currentLevel;     // 1-based index of the level being played
    // [HideInInspector] public int maxUnlockedLevel; // Highest unlocked level (1 = first level unlocked)

    // // Internal state for current level:
    // private bool[] foundDifferences;
    // private int hintsRemaining;

    // private void Awake()
    // {
    //     // Singleton pattern
    //     if (Instance == null) {
    //         Instance = this;
    //         DontDestroyOnLoad(gameObject);
    //         // Load unlocked level or default to 1
    //         maxUnlockedLevel = PlayerPrefs.GetInt("MaxUnlockedLevel", 1);
    //         maxUnlockedLevel = Mathf.Clamp(maxUnlockedLevel, 1, totalLevels);
    //     } else {
    //         Destroy(gameObject);
    //     }
    // }

    // /// <summary>
    // /// Call to start a level: sets current level and loads the LevelScene.
    // /// </summary>
    // public void GoToLevel(int levelNumber)
    // {
    //     if (levelNumber < 1 || levelNumber > totalLevels) {
    //         Debug.LogError("Invalid level number: " + levelNumber);
    //         return;
    //     }
    //     currentLevel = levelNumber;
    //     SceneManager.LoadScene("LevelScene");
    // }

    // /// <summary>
    // /// Call from Level select or LevelController to initialize UI and level data when a level scene loads.
    // /// </summary>
    // /// <param name="leftImageUI">UI Image for left side</param>
    // /// <param name="rightImageUI">UI Image for right side</param>
    // /// <param name="differencesParent">Parent transform under which difference buttons will be created (e.g. the right image)</param>
    // /// <param name="differenceButtonPrefab">Prefab for the invisible button marking a difference</param>
    // /// <param name="foundHighlightPrefab">Prefab for highlighting a found difference</param>
    // /// <param name="hintText">UI Text displaying remaining hints</param>
    // /// <param name="hintButton">UI Button to request a hint</param>
    // public void SetupLevel(Image leftImageUI, Image rightImageUI, Transform differencesParent,
    //                        GameObject differenceButtonPrefab, GameObject foundHighlightPrefab,
    //                        Text hintText, Button hintButton)
    // {
    //     // Reset hint count and differences found state
    //     hintsRemaining = hintsPerLevel;
    //     hintText.text = "Hints: " + hintsRemaining;
    //     hintButton.interactable = (hintsRemaining > 0);

    //     // Get level data (array is 0-indexed, levels are 1-based)
    //     LevelData levelData = levels[currentLevel - 1];
    //     if (levelData == null || levelData.leftImage == null || levelData.rightImage == null || levelData.differencePositions.Length == 0) {
    //         Debug.LogError("LevelData for level " + currentLevel + " is not properly set.");
    //         return;
    //     }

    //     // Set the UI images for this level
    //     leftImageUI.sprite = levelData.leftImage;
    //     rightImageUI.sprite = levelData.rightImage;

    //     // Prepare tracking array for differences found
    //     int diffCount = levelData.differencePositions.Length;
    //     foundDifferences = new bool[diffCount];

    //     // Create interactive buttons for each difference position
    //     for (int i = 0; i < diffCount; i++) {
    //         Vector2 pos = levelData.differencePositions[i];
    //         // Instantiate a transparent button at the given position
    //         GameObject diffBtn = Instantiate(differenceButtonPrefab, differencesParent);
    //         RectTransform rect = diffBtn.GetComponent<RectTransform>();
    //         rect.anchoredPosition = pos;  // Position relative to parent (see UI instructions)
    //         // Assign a click listener that marks this difference when tapped
    //         int index = i; // capture loop index
    //         Button btn = diffBtn.GetComponent<Button>();
    //         btn.onClick.AddListener(() => OnDifferenceClicked(index, foundHighlightPrefab));
    //     }
    // }

    // /// <summary>
    // /// Called when a difference button is tapped. Marks it found, shows highlight, and checks for level completion.
    // /// </summary>
    // private void OnDifferenceClicked(int index, GameObject foundHighlightPrefab)
    // {
    //     if (index < 0 || index >= foundDifferences.Length || foundDifferences[index]) {
    //         return; // already found or invalid
    //     }
    //     foundDifferences[index] = true;

    //     // Instantiate a found marker at the same position (for feedback)
    //     // Assumes difference buttons are children of a RectTransform with the same anchor setup
    //     GameObject highlight = Instantiate(foundHighlightPrefab, 
    //         GameObject.Find("RightImage").transform); // parent it under the right image
    //     RectTransform rectH = highlight.GetComponent<RectTransform>();
    //     // Use the same local position as the button
    //     rectH.anchoredPosition = levels[currentLevel - 1].differencePositions[index];

    //     // Check if all differences are found
    //     bool allFound = true;
    //     foreach (bool found in foundDifferences) {
    //         if (!found) { allFound = false; break; }
    //     }
    //     if (allFound) {
    //         LevelComplete();
    //     }
    // }

    // /// <summary>
    // /// Use a hint: highlights one random remaining difference. Called by HintManager/UI.
    // /// </summary>
    // public void UseHint()
    // {
    //     if (hintsRemaining <= 0) return;

    //     // Find indices of unfound differences
    //     List<int> remaining = new List<int>();
    //     for (int i = 0; i < foundDifferences.Length; i++) {
    //         if (!foundDifferences[i]) remaining.Add(i);
    //     }
    //     if (remaining.Count == 0) return; // nothing to hint

    //     // Choose a random unfound difference
    //     int randIndex = remaining[Random.Range(0, remaining.Count)];

    //     // Highlight it temporarily (reuse foundHighlightPrefab or a separate hint prefab)
    //     LevelData levelData = levels[currentLevel - 1];
    //     // GameObject hintMarker = Instantiate(levels[currentLevel - 1].leftImage); // Dummy: replace with actual highlight prefab
    //     // Note: Replace above line with your actual highlight prefab instantiation.
    //     // Example: Instantiate(hintHighlightPrefab, rightImageParent);

    //     // Reduce hint count and update UI
    //     hintsRemaining--;
    //     Text hintText = GameObject.Find("HintText").GetComponent<Text>();
    //     hintText.text = "Hints: " + hintsRemaining;
    //     if (hintsRemaining <= 0) {
    //         Button hintBtn = GameObject.Find("HintButton").GetComponent<Button>();
    //         hintBtn.interactable = false;
    //     }
    // }

    // /// <summary>
    // /// Called when a level is completed (all differences found). Unlocks next level and returns to Level Select.
    // /// </summary>
    // private void LevelComplete()
    // {
    //     // Unlock next level if it exists
    //     if (currentLevel == maxUnlockedLevel && currentLevel < totalLevels) {
    //         maxUnlockedLevel = currentLevel + 1;
    //         PlayerPrefs.SetInt("MaxUnlockedLevel", maxUnlockedLevel);
    //     }
    //     // Return to Level Select scene (or load next level, as desired)
    //     SceneManager.LoadScene("LevelSelect");
    // }
}

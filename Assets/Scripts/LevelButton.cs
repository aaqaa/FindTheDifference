using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelButton : MonoBehaviour
{
    [Header("UI References")]
    public Image mainImage;
    public TMP_Text numberText;
    public TMP_Text timerText;
    public Button button;

    [HideInInspector]
    public int currentLevelIndex = -1;
}

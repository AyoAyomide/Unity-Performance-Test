using TMPro;
using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fpsText;

    private int frameCount; // Count frames between updates
    private float deltaTime; // Time between updates

    private void Start()
    {
        Application.targetFrameRate = 30;
        frameCount = 0;
        deltaTime = Time.unscaledDeltaTime; // Use unscaled for smoother calculations

    }

    private void Update()
    {
        frameCount++;
        deltaTime += Time.unscaledDeltaTime;

        if (deltaTime >= 0.2f) // Update FPS display every second
        {
            float fps = Mathf.FloorToInt(frameCount / deltaTime); // Calculate FPS
            fpsText.text = "FPS: " + fps.ToString(); // Update UI Text

            frameCount = 0;
            deltaTime = 0.0f;
        }
    }
}
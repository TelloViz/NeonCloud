using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorManager : MonoBehaviour, IColorChangeable {
    [SerializeField]
    Vector2 redRange, greenRange, blueRange, alphaRange;

    private Renderer rend;

    #region MonoBehaviour
    private void Awake() {
        rend = GetComponent<Renderer>();
    }
    #endregion

    #region Class Methods
    public void ChangeColorTo(Color newColor) {
        rend.material.color = newColor;
    }

    public void ChangeToRandomColor() {
        float randRed = UnityEngine.Random.value;
        float randGreen = UnityEngine.Random.value;
        float randBlue = UnityEngine.Random.value;
        float randAlpha = UnityEngine.Random.value;
        rend.material.color = new Color(randRed, randGreen, randBlue, randAlpha);
    }

    public void ChangeToRandomColorInRange() {
        float randRed = UnityEngine.Random.Range(redRange.x, redRange.y);
        float randGreen = UnityEngine.Random.Range(greenRange.x, greenRange.y);
        float randBlue = UnityEngine.Random.Range(blueRange.x, blueRange.y);
        float randAlpha = UnityEngine.Random.Range(alphaRange.x, alphaRange.y);
        rend.material.color = new Color(randRed, randGreen, randBlue, randAlpha);
    }
    #endregion
}

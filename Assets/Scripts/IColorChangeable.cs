using UnityEngine;

internal interface IColorChangeable {
    void ChangeColorTo(Color newColor);
    void ChangeToRandomColor();
    void ChangeToRandomColorInRange();
}
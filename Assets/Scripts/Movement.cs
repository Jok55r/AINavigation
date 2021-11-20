using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        GoToCursor();
    }

    private void GoToCursor()
    {
        Vector2 mousePosition = Input.mousePosition;
        transform.position = mousePosition;
    }
}
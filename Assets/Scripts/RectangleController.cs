using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class RectangleController : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _collider;
    [SerializeField] private UnityEvent _action;

    private void OnValidate()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        _action.Invoke();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown (0) | Input.touchCount == 1) {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            if (hitInfo.collider == _collider)
            {
                _action.Invoke();
            }
        }
    }
}
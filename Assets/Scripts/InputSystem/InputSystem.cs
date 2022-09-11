using UnityEngine;

namespace Input
{
    public class InputSystem : MonoBehaviour
    {
        [SerializeField] private Ball ball;
        [SerializeField] private float forceMultiplyer;
        
        private Vector2 _initialPosition;
        private bool _dragStarted;
        
        private void OnEnable()
        {
            ball.OnMouseButtonDown += OnBallMouseDown;
        }

        private void OnDisable()
        {
            ball.OnMouseButtonDown -= OnBallMouseDown;
        }

        private void Update()
        {
            if (_dragStarted)
            {
                if (UnityEngine.Input.GetMouseButtonUp(0))
                {
                    Vector2 currentPosition = UnityEngine.Input.mousePosition;
                    Vector2 direction = _initialPosition - currentPosition;
                    direction.Normalize();
                    float force = Vector2.Distance(_initialPosition, currentPosition) * forceMultiplyer;
                    
                    Debug.Log("direction: " + direction + " initial: " + _initialPosition + " curr: " + currentPosition);
                    
                    ball.Push(direction, force);
                }
            }
        }

        private void OnBallMouseDown()
        {
            _initialPosition = UnityEngine.Input.mousePosition;
            _dragStarted = true;
        }
    }
}

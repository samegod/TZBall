using BallScripts;
using UnityEngine;
using UnityEngine.UI;

public class RollerTestButton : MonoBehaviour
{
	[SerializeField] private BallRoller roller;
	[SerializeField] private Vector3 direction;
	[SerializeField] private float speed;
	
	private Button _button;

	private void Awake()
	{
		_button = GetComponent<Button>();
		_button.onClick.AddListener(() => roller.Push(direction, speed));
	}
}

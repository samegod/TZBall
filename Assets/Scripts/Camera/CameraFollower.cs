using UnityEngine;

namespace CameraScripts
{
	[RequireComponent(typeof(Camera))]
	public class CameraFollower : MonoBehaviour
	{
		[SerializeField] private Transform target;
		[SerializeField] private Vector3 offset;
		[SerializeField] private float speedModifyer = 1;

		private bool _canMove = true;
		
		public bool CanMove
		{
			get => _canMove;
			set => _canMove = value;
		}
		public Transform Target => target;
		public Vector3 Offset => offset;

		private void Update()
		{
			if (_canMove)
			{
				Vector3 newTarget = Target.position + Offset;
				transform.position = Vector3.Lerp(transform.position, newTarget, Time.deltaTime * speedModifyer);
			}
		}
	}
}
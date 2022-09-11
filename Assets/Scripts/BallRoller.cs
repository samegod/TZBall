using System;
using UnityEngine;

namespace BallScripts
{
	public class BallRoller : MonoBehaviour
	{
		[SerializeField] private float speedDecreaseValue;
		
		private float _speed;
		private Vector3 _moveDirection;
		private bool _isMovingNow = true;

		private void Update()
		{
			if (_isMovingNow == false)
				return;

			transform.Translate(_moveDirection * (_speed * Time.deltaTime));

			DecreaseSpeed();
		}

		public void Push (Vector2 direction, float speed)
		{
			_moveDirection.x = direction.x;
			_moveDirection.z = direction.y;
			_speed = speed;
			_isMovingNow = true;
		}

		private void DecreaseSpeed()
		{
			if (speedDecreaseValue > _speed)
			{
				StopMotion();
				return;
			}

			_speed -= speedDecreaseValue;
		}

		private void StopMotion()
		{
			_isMovingNow = false;
			_speed = 0;
			_moveDirection = Vector3.zero;
		}
	}
}
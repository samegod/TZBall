using System;
using BallScripts;
using UnityEngine;

[RequireComponent(typeof(BallRoller))]
public class Ball : MonoBehaviour
{
	public event Action OnMouseButtonDown;

	private BallRoller _roller;

	private void Awake()
	{
		_roller = GetComponent<BallRoller>();
	}

	private void OnMouseDown()
	{
		OnMouseButtonDown?.Invoke();
	}

	public void Push(Vector2 direction, float force)
	{
		_roller.Push(direction, force);
	}
}
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class Player : Mech
	{

		public Weapon Weapon;

		private void Start()
		{

		}

		private void Update()
		{
	
			
			
			base.Update();
			if (Input.GetKey(KeyCode.W))
			{
				Move(Direction.Forward);
			} 
			else if (Input.GetKey(KeyCode.S))
			{
				Move(Direction.Backward);
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				Move(Direction.Left);
			} 
			else if (Input.GetKey(KeyCode.D))
			{
				Move(Direction.Right);
			}

			if (Input.GetMouseButton(0))
			{
				
			}
		}

		private void Shoot()
		{
			
		}
	}
}
using UnityEngine;

namespace Core
{
	public class Player : Mech
	{
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
		}
	}
}
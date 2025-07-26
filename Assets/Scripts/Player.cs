using UnityEngine;

namespace Core
{
	public class Player : Mech
	{
		private void Update()
		{
			if (Input.GetKey(KeyCode.W))
			{
				transform.position += transform.forward * moveSpeed * Time.deltaTime;
			} 
			else if (Input.GetKey(KeyCode.S))
			{
				transform.position -= transform.forward * moveSpeed * Time.deltaTime;
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				transform.position -= transform.right * moveSpeed * Time.deltaTime;
			} 
			else if (Input.GetKey(KeyCode.D))
			{
				transform.position += transform.right * moveSpeed * Time.deltaTime;
			}
		}
	}
}
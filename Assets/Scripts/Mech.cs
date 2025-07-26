using System;
using UnityEngine;

namespace Core
{
	public class Mech : MonoBehaviour
	{
		
		public enum Type { None, Player, Enemy }
		
#region Stats
		[Header("Stats")] [Range(0,100)]    public int health = 100;

		[Range(0,50)]                       public float moveSpeed = 5f;

		[Range(0,500)]                      public float energy = 500;
		[Range(0,50)]                       public float energyRegenerationPerSecond = 5;
		[Range(0,10)]                       public float heightOffset = 2.5f;
		public Type type = Type.None;
#endregion
		private void Update()
		{
			// Raycast downwards to find the ground
			RaycastHit hit;
			// Define the origin of the raycast (e.g., slightly above the mech's current position)
			Vector3 rayOrigin = transform.position + Vector3.up * 1f; // Start slightly above to avoid self-intersection

			// Define the maximum distance for the raycast
			float rayDistance = heightOffset + 2f; // Extend a bit beyond the heightOffset

			// Layer mask for filtering what the raycast hits
			// You can set this in the Inspector or dynamically
			int groundLayer = LayerMask.GetMask("Ground"); // Assumes you have a "Ground" layer

			if (Physics.Raycast(rayOrigin, Vector3.down, out hit, rayDistance, groundLayer))
			{
				// If the raycast hits something on the "Ground" layer
				transform.position = new Vector3(transform.position.x, hit.point.y + heightOffset, transform.position.z);
			}

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

		// You might want to visualize the raycast in the editor for debugging
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.red;
			Vector3 rayOrigin = transform.position + Vector3.up * 1f;
			Gizmos.DrawLine(rayOrigin, rayOrigin + Vector3.down * (heightOffset + 2f));
		}
		
		
		
		
		
	}
}
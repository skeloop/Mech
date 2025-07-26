using UnityEngine;

public class Mech : Entity
{
		
	#region Stats
	[Header("Stats")] [Range(0,100)]    public int health = 100;

	[Range(0,50)]                       public float moveSpeed = 5f;

	[Range(0,500)]                      public float energy = 500;
	[Range(0,50)]                       public float energyRegenerationPerSecond = 5;
	[Range(0,10)]                       public float heightOffset = 2.5f;
	#endregion
	private void Update()
	{
		RaycastHit hit;
		Vector3 rayOrigin = transform.position + Vector3.up * 1f; 
		
		float rayDistance = heightOffset + 2f; 
		int groundLayer = LayerMask.GetMask("Ground"); 

		if (Physics.Raycast(rayOrigin, Vector3.down, out hit, rayDistance, groundLayer))
		{
			transform.position = new Vector3(transform.position.x, hit.point.y + heightOffset, transform.position.z);
		}


		
	}
	
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Vector3 rayOrigin = transform.position + Vector3.up * 1f;
		Gizmos.DrawLine(rayOrigin, rayOrigin + Vector3.down * (heightOffset + 2f));
	}
}
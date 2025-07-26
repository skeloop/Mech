using UnityEngine;

public enum Direction {Forward, Backward, Left, Right}

public abstract class Mech : Entity
{
	#region Stats
	[Header("Stats")] 
		
	[Range(0,50)] 	public float moveSpeed = 5f;
	[Range(0,50)] 	public float glideSpeed = 15f;

	// wird zum wegboosten verwendet -> x anzahl
	[Range(0,500)]	public float energy = 500;
	[Range(0,50)] 	public float energyRegenerationPerSecond = 5;
	
	[Range(0,10)] 	public float heightOffset = 2.5f;
	#endregion
	protected void Update()
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

	protected void Move(Direction direction)
	{
		switch (direction)
		{
			case Direction.Forward:
				transform.position += transform.forward * moveSpeed * Time.deltaTime;
				break;
			case Direction.Backward:
				transform.position -= transform.forward * moveSpeed * Time.deltaTime;
				break;
			case Direction.Left:
				transform.position -= transform.right * moveSpeed * Time.deltaTime;
				break;
			case Direction.Right:
				transform.position += transform.right * moveSpeed * Time.deltaTime;
				break;
		}
	}
	
	float lastBoostTime = 0;


	
	private void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Vector3 rayOrigin = transform.position + Vector3.up * 1f;
		Gizmos.DrawLine(rayOrigin, rayOrigin + Vector3.down * (heightOffset + 2f));
	}
}
using System;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
	[Range(0,100)]	public int health = 100;
	[Range(0,50)]   public float healthRegenerationPerSecond = 5;
	
	private void Regenerate()
	{
		
	}
}
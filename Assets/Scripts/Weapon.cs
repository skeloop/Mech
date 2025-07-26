using UnityEngine;

namespace Core
{
	[CreateAssetMenu(fileName = "MechWeapon", menuName = "Weapon", order = 0)]
	public abstract class Weapon : ScriptableObject
	{
		public float Damage;
		public float ShootDelay;
	}

	public class Laser : Weapon
	{
		
	}

	public class Projectile : Weapon
	{
		
	}

	public class Missile : Weapon
	{
		
	}
	
	
}
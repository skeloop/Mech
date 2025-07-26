using UnityEngine;

namespace Core
{
	public abstract class Weapon : ScriptableObject
	{
		[Range(0,100)]
		public float Damage;
		public float ShootDelay;
	}

	[CreateAssetMenu(fileName = "MechWeapon", menuName = "Laser Weapon", order = 0)]
	public class Laser : Weapon
	{
		
	}
	[CreateAssetMenu(fileName = "MechWeapon", menuName = "Gun Weapon", order = 0)]
	public class Projectile : Weapon
	{
		
	}

	[CreateAssetMenu(fileName = "MechWeapon", menuName = "Missile Launcher", order = 0)]
	public class Missile : Weapon
	{
		
	}
	
	
}
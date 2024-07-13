using BeInTheirMind;
using Godot;
using Godot.Collections;
using System;

public interface IEntity 
{
	public string name { get; set; }
	public string description { get; set; }
	/// <summary>
	/// Normallized vector
	/// </summary>
	public Vector2 Direction {  get; set; }
	public int hp {  get; set; }
	public float baseSpeed {  get; }
	/// <summary>
	/// include all modifier on Base Speed
	/// </summary>
	public float currentSpeed {  get; set; }
	/// <summary>
	/// unified ID
	/// </summary>
	public uint ID {  get => (uint)this.GetHashCode()+int.MaxValue; }
	/// <summary>
	/// Store for every dmgmod.
	/// </summary>
	public Dictionary<DamageType, float> dmgModifier {  get; set; }
	/// <summary>
	/// include counting from dmgModifier
	/// </summary>
	/// <param name="Count"></param>
	/// <param name="damageType"></param>
	public void TakeDmg(int Count, DamageType damageType);
	/// <summary>
	/// trigger than death
	/// </summary>
	protected void OnDeath();
	/// <summary>
	/// Just move forward
	/// </summary>
	public void Move();

}

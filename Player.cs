using BeInTheirMind;
using Godot;
using Godot.Collections;
using System;

public partial class Player : Area2D, IEntity
{
	#region IEntity
	private string _name;
	string IEntity.name { get =>_name; set => _name = value; }
	private string _description;
	string IEntity.description { get => _description; set => _description = value; }
	private Vector2 _direction;
	Vector2 IEntity.Direction { get => _direction; set => _direction = value.Normalized(); }
	private int _hp;
	int IEntity.hp { get => _hp; set => _hp = value; }
	private float _baseSpeed;
	float IEntity.baseSpeed { get => _baseSpeed;}
	private float _currentSpeed;
	float IEntity.currentSpeed { get => _currentSpeed; set => _currentSpeed = value; }
	private Dictionary<DamageType, float> _dmgModifier;
	Dictionary<DamageType, float> IEntity.dmgModifier { get => _dmgModifier; set => throw new NotImplementedException(); }
	#endregion



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	void IEntity.TakeDmg(int Count, DamageType damageType)
	{
		_hp -= (int)(Count * _dmgModifier[damageType] + 0.5f);
	}

	void IEntity.OnDeath()
	{
		Dispose();
	}
	void IEntity.Move()
	{
		Position += _direction * _currentSpeed;
	}
}

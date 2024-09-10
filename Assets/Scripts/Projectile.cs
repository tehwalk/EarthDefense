using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewProjectile", menuName ="Game Elements/Projectile")]
public class Projectile : ScriptableObject
{
    public string p_Name;
    public string p_Description;
    public int p_LifePoints;
    public int p_DamagePoints;
    public float p_Speed;
    public GameObject p_GFX;
    public GameObject p_Particles;
}

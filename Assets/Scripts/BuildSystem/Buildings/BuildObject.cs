using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New loose building", menuName = "Buildings/Loose building")]
public abstract class BuildObject : ScriptableObject
{
    public BuildingType buildingType;
    public Vector2 size;
    public Mesh mesh;
}

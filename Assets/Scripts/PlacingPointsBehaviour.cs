using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingPointsBehaviour : OrbitingBehaviour
{
    [SerializeField] Material unselectedMaterial;
    [SerializeField] Material selectedMaterial;
    MeshRenderer meshRenderer;
    protected override void Start() 
    { 
        base.Start();
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        meshRenderer.material = unselectedMaterial;
    }
    protected override void OnHoverEnter()
    {
        base.OnHoverEnter();
        meshRenderer.material = selectedMaterial;
        
    }

    protected override void OnHoverExit()
    {
        base.OnHoverExit();
        meshRenderer.material = unselectedMaterial;
    }
}

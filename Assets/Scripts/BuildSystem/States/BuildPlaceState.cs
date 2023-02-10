using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// something is selected to build
public class BuildPlaceState : State<BuildManager>
{
    private FSM<BuildManager> owner;
    private BuildManager buildManager;

    private BuildObject selection;
    private GameObject selectionRender;

    public BuildPlaceState(FSM<BuildManager> _owner)
    {
        owner = _owner;
        buildManager = owner.Owner;
    }

    public override void OnEnter()
    {
        base.OnEnter();
        selection = buildManager.CurrentSelection;
        selectionRender = new GameObject("Selected Object", 
            typeof(MeshRenderer), 
            typeof(MeshFilter)   
        );

        Debug.Log($"Selection: {selection}. Selection Render: {selectionRender}");
        selectionRender.GetComponent<MeshFilter>().mesh = selection.mesh;
        selectionRender.GetComponent<MeshRenderer>().material = buildManager.selectionMaterial;
    }

    public override void OnUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            selectionRender.transform.position = ray.GetPoint(hit.distance);

            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        Object.Destroy(selectionRender);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// building system is active but nothing is currently being placed - player is selecting
public class BuildSelectState : State<BuildManager>
{
    private FSM<BuildManager> owner;
    private BuildManager buildSystem;

    public BuildSelectState(FSM<BuildManager> _owner)
    {
        owner = _owner;
        buildSystem = owner.Owner;
    }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }
    
    public override void OnExit()
    {
        base.OnExit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// when the building system is entirely inactive
public class BuildInactiveState : State<BuildSystem>
{
    private FSM<BuildSystem> owner;
    private BuildSystem buildSystem;
    public BuildInactiveState(FSM<BuildSystem> _owner)
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

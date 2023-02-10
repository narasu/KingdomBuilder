using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// when the building system is entirely inactive
public class BuildInactiveState : State<BuildManager>
{
    private FSM<BuildManager> owner;
    private BuildManager buildSystem;
    public BuildInactiveState(FSM<BuildManager> _owner)
    {
        owner = _owner;
        buildSystem = owner.Owner;
    }

    public override void OnEnter()
    {
        base.OnEnter();

        //disable build system
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }

    public override void OnExit()
    {
        base.OnExit();

        //enable build system
    }
}

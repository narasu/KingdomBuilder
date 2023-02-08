using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{
    FSM<BuildSystem> fsm;

    private void Awake()
    {
        fsm = new FSM<BuildSystem>();
        fsm.Initialize(this);
        fsm.AddState(new BuildInactiveState(fsm));
        //fsm.SwitchState(typeof(BuildInactiveState));
    }

    void Start()
    {
        
    }

    void Update()
    {
        fsm.Update();
    }
}

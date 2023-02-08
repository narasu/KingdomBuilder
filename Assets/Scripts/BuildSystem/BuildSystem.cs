using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the 'wrapper' that kinda ties everything together
public class BuildSystem : MonoBehaviour
{
    private FSM<BuildSystem> fsm;

    public GameObject tempPrefab;

    private void Awake()
    {
        fsm = new FSM<BuildSystem>();
        fsm.Initialize(this);
        fsm.AddState(new BuildInactiveState(fsm));
        fsm.SwitchState(typeof(BuildInactiveState));
    }

    void Start()
    {
        
    }

    void Update()
    {
        fsm.Update();
    }
}

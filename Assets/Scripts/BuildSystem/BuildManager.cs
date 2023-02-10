using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the 'wrapper' that kinda ties everything together
public class BuildManager : MonoBehaviour
{
    private FSM<BuildManager> fsm;

    public BuildObject CurrentSelection
    {
        get
        {
            return currentSelection;
        }

        private set
        {
            currentSelection = value;
            if (value == null && fsm.CurrentState == typeof(BuildPlaceState))
            {
                fsm.SwitchState(typeof(BuildSelectState));
            }
            else if (value!=null && fsm.CurrentState == typeof(BuildSelectState))
            {
                Debug.Log($"Current selection: {value}");
                fsm.SwitchState(typeof(BuildPlaceState));
            }
        }
    }
    private BuildObject currentSelection;
    public Material selectionMaterial;

    private void Awake()
    {
        fsm = new FSM<BuildManager>();
        fsm.Initialize(this);
        fsm.AddState(new BuildInactiveState(fsm));
        fsm.AddState(new BuildSelectState(fsm));
        fsm.AddState(new BuildPlaceState(fsm));
        fsm.SwitchState(typeof(BuildSelectState));
    }

    void Start()
    {
        
    }

    void Update()
    {
        fsm.Update();
    }

    public void SelectBuilding(BuildObject _building)
    {
        if (fsm.CurrentState == typeof(BuildInactiveState))
        {
            Debug.Log("Building selected while build system is inactive! Make sure it's enabled and disabled properly!");
            return;
        }
        CurrentSelection = _building;
    }

}

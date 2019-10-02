using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GvrTrackedController Controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controller.ControllerInputDevice.GetButtonDown(GvrControllerButton.App))
        {
            SwitchRoom.Instance.RoomSwitcher();
        }
    }
}

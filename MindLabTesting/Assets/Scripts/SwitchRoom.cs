using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoom : MonoBehaviour
{
    public GameObject room1, room2;
    int whichRoomisOn = 1;
    public static SwitchRoom Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        room1.gameObject.SetActive(true);
        room2.gameObject.SetActive(false);
    }

    public void RoomSwitcher()
    {
        switch (whichRoomisOn)
        {
            case 1:
                whichRoomisOn = 2;
                room1.gameObject.SetActive(false);
                room2.gameObject.SetActive(true);
                break;
            case 2:
                whichRoomisOn = 1;
                room1.gameObject.SetActive(true);
                room2.gameObject.SetActive(false);
                break;
        }
    }
}

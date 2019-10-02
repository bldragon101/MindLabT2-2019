using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class SaveLoad : MonoBehaviour
{
    public string Name;
    void Save()
    {
        JSONObject objectJson = new JSONObject();
        objectJson.Add("Name", Name);

        JSONArray position = new JSONArray();
        position.Add(transform.position.x);
        position.Add(transform.position.y);
        position.Add(transform.position.z);
        objectJson.Add("Position", position);

        string path = Application.dataPath + "/objectSave.json";
        File.WriteAllText(path, objectJson.ToString());

        Debug.Log(objectJson.ToString());
    }

    void Load()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) Save();
        if (Input.GetKeyDown(KeyCode.L)) Load();
    }
}

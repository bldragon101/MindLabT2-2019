using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBundle : MonoBehaviour
{
    IEnumerator Start()
    {
        string url = "https://mindlab2019s3.s3.amazonaws.com/Android/sidetable";
        WWW www = new WWW(url);
        while (!www.isDone)
            yield return null;
        AssetBundle sidetable = www.assetBundle;
        GameObject Mya = sidetable.LoadAsset<GameObject>("SideTable") as GameObject;
        Instantiate(Mya);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class GameAssets : MonoBehaviour
{
    //this is the class where i host my prefabs
    //
    //easy calling = GameAssets.i.prefabName;

    private static GameAssets _i;
    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;
        }
    }

    //prefabs
    public Transform pf_popUpText;
}

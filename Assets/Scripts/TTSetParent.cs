using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTSetParent : MonoBehaviour
{
    public bool worldspace;
    public Transform parent;

    void Start()
    {
        gameObject.transform.SetParent(parent, worldspace);
    }
}

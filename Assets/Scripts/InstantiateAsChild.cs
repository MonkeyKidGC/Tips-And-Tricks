using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAsChild : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    public Vector2 position;
    public Quaternion rotation;

    public void childInstantiate()
    {
        GameObject childGameObject = Instantiate(prefab);
        childGameObject.name = "Instantiate";
    }

    public void childInstantiateAsChild()
    {
        GameObject childGameObject = Instantiate(prefab, parent);
        childGameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,0);
        childGameObject.name = "InstantiateChild";

    }

    public void childInstantiateAsChildWorldSpace()
    {
        GameObject childGameObject = Instantiate(prefab, parent, true);
        childGameObject.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
        childGameObject.name = "InstantiateWorldSpace";
    }

    public void childInstantiateWithPositionRotation()
    {
        GameObject childGameObject = Instantiate(prefab, position, rotation);
        childGameObject.GetComponent<SpriteRenderer>().color = new Color(0,255,0);
        childGameObject.name = "InstantiatePosAndRot";
    }
    public void childInstantiateAsChildWithPositionRotation()
    {
        GameObject childGameObject = Instantiate(prefab, position, rotation ,parent);
        childGameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,255);
        childGameObject.name = "InstantiateChildPosAndRot";
    }

}

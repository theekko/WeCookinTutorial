using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This allows you to create an instance of your ScriptableObject in the add object menu
[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {


    /*Can use a SerializeField with private, but because you almost never write to
     but because you never write to a ScribtableObject it is safe to call it public*/
    public Transform prefab;
    public Sprite sprite;
    public string objectName;


}

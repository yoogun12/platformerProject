using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] ItemSo date;
    

    public int GetPoint()
    {
        return date.point;
    }
}

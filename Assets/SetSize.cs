using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSize : MonoBehaviour
{
    public float ScaleOffest;

    public void ScaleUp()
    {
        transform.localScale += Vector3.one*ScaleOffest;
    }
    
    public void ScaleDown()
    {
        transform.localScale -= Vector3.one*ScaleOffest;
    }
    
}

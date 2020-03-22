using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfNotFirst : MonoBehaviour
{
    private void Awake()
    {
        if (!InputStorage.firstTimeStartup)
        {
            Destroy(gameObject);
        }
    }
}

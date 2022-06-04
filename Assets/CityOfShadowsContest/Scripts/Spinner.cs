using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    void Update() => transform.rotation *= Quaternion.AngleAxis(50f * Time.deltaTime, Vector3.up);
}

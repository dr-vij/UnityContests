using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    [SerializeField] private Light m_Light = default;
    [SerializeField] private AnimationCurve m_Curve = default;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * 50f, Vector3.right);
        m_Light.intensity = m_Curve.Evaluate(m_Light.transform.position.y);
    }
}

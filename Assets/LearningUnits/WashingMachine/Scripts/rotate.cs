using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    Vector3 staystill;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>(); //changed the Iskinematic in inspector
        m_EulerAngleVelocity = new Vector3(0, 100, 0);
        staystill = new Vector3(6.91f,1.963f,-11.23f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = staystill;
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroInputBasic : MonoBehaviour
{
    Gyroscope m_Gyro;
    public Text rot;
    public Text att;
    public Text enable;

    void Start()
    {
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }
    void OnGUI()
    {
        rot.text = "Gyro rotation rate " + m_Gyro.rotationRate;
        att.text = "Gyro attitude" + m_Gyro.attitude;
        enable.text = "Gyro enabled : " + m_Gyro.enabled;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    [Tooltip("The text element that should display the current speed")]
    public TMP_Text speedometerText;
    [Tooltip("The rigidbody that the speedometer should track the speed of")]
    public Rigidbody bodyToTrack;

    // Update is called once per frame
    void Update()
    {
        if (bodyToTrack != null)
        {
            int bodySpeed = Mathf.RoundToInt(new Vector3(bodyToTrack.velocity.x, 0, bodyToTrack.velocity.z).magnitude);

            if (bodySpeed > 999)
            {
                bodySpeed = 999;
            }

            speedometerText.text = bodySpeed.ToString("D3");
        }
    }
}

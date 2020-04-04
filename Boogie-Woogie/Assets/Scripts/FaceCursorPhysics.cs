using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCursorPhysics : MonoBehaviour
{
    public float smooth;
    private Quaternion targetRotation;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        targetRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb2d.rotation = (Mathf.LerpAngle(rb2d.rotation, Quaternion.AngleAxis(angle - 90, Vector3.forward).eulerAngles.z, Time.deltaTime * smooth));


    }
}

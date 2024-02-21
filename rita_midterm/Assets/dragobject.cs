using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragobject : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;


    void OnMouseDown()
    {
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private void GetMouseWorldPos()
    {

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 mousePoint = Input.mousePosition;
    }


    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }


}

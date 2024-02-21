using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{

    public Camera firstPersonCamera;
    public Camera overheadCamera;

    private void Start()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;

    }



    // Start is called before the first frame update
    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }



    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }


    private void Update()
    {

    

    }

    void OnMouseDown()
    {
        ShowOverheadView();
        // this object was clicked - do something
        //Destroy(this.gameObject);
    }



}

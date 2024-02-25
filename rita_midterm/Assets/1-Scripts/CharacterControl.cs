using Cinemachine;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] CinemachinePathBase path;

    public float MoveSpeed = 5;
    public float CameraSensitivity = 2;
    public float CameraSmoothing = 1.5f;

    float position = 0;
    Vector2 velocity;
    Vector2 frameVelocity;
    Vector3 pathDirection;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            UpdatePosition();
        }   
        UpdateRotation();
    }

    private void UpdateRotation()
    {
        // Get smooth velocity.
        Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * CameraSensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / CameraSmoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Rotate camera up-down and controller left-right from velocity.
        transform.localRotation = Quaternion.Euler(-velocity.y, velocity.x, 0);
    }


    private void UpdatePosition()
    {
        if (path != null)
        {
            Vector3 dir = path.EvaluatePositionAtUnit(position + 0.01f, CinemachinePathBase.PositionUnits.Distance) 
                - path.EvaluatePositionAtUnit(position, CinemachinePathBase.PositionUnits.Distance);
            float direction = Vector3.Dot(dir, transform.forward);
            if (direction < 0)
            {
                position -= Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
            }
            else
            {
                position += Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
            }
            position = Mathf.Clamp(position, 0, path.PathLength);
            float pos = path.StandardizeUnit(position, CinemachinePathBase.PositionUnits.Distance);
            transform.position = path.EvaluatePositionAtUnit(pos, CinemachinePathBase.PositionUnits.Distance);
        }
    }

}

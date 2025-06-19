using UnityEngine;

public class MovimentoCam : MonoBehaviour
{
    [SerializeField] public float sensiCam = 5f;

    [SerializeField] public float distMin;
    [SerializeField] public float distMax;

    float distcam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distcam = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        distcam = Mathf.Clamp(distcam + Input.GetAxis("Mouse X") * sensiCam, distMin, distMax);
        transform.rotation = Quaternion.Euler(0f, distcam, 0f);
    }
}

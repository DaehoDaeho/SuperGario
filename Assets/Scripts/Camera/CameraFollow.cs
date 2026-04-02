using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;

    // 카메라가 목표 위치를 따라가는 속도.
    // 이 값이 클수록 더 빠르게 따라간다.
    [SerializeField] private float followSpeed = 5.0f;

    // Update is called once per frame
    void LateUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        // 대상의 위치정보를 읽어온다. (x, y, z)
        Vector3 targetPosition = targetTransform.position;

        // 카메라의 위치값 생성. (x만 대상의 정보를 사용하고, y와 z는 카메라의 정보를 그대로 사용.)
        Vector3 cameraPosition = new Vector3(targetPosition.x, transform.position.y, transform.position.z);

        // 카메라의 위치 반영.
        //transform.position = cameraPosition;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);
    }
}

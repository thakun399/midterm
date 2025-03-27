using UnityEngine;

public class Walk : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 60f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() // เปลี่ยนจาก Update เป็น FixedUpdate
    {
        float move = Input.GetAxis("Vertical") * moveSpeed;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.fixedDeltaTime;

        // รีเซ็ตแรงที่ไม่ต้องการ
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // เคลื่อนที่ไปข้างหน้า
        Vector3 moveDirection = transform.forward * move * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);
        
        // หมุนรถถัง
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
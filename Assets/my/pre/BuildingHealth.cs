using UnityEngine;

public class BuildingHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // ตั้งค่าเลือดเริ่มต้น
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log("Building HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            DestroyBuilding(); // ทำลายตึกถ้าเลือดหมด
        }
    }

    void DestroyBuilding()
    {
        Debug.Log("Building Destroyed!");
        Destroy(gameObject); // ลบตึกออกจากฉาก
    }
}

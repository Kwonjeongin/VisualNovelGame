using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int hintKeys = 0; // �ʱ� ��Ʈ ���� ��

    // ��Ʈ ���踦 �߰��ϴ� �޼���
    public void AddHintKey()
    {
        hintKeys++;
        Debug.Log("Hint key added. Total keys: " + hintKeys);
    }
}

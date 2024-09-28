using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public int hintKeys = 0; // �÷��̾ ������ �ִ� ��Ʈ Ű ����
    public int hintKeyPrice = 1; // ��Ʈ Ű ����
    public TMP_Text hintKeyText; // ��Ʈ Ű ������ ������ TextMeshProUGUI

    void Start()
    {
        UpdateHintKeyText(); // ���� �� �ؽ�Ʈ ������Ʈ
    }

    // ��Ʈ Ű�� �����ϴ� �޼���
    public void BuyHintKey()
    {
        // �÷��̾ �ݾ� ���� �ٷ� ���� ����
        hintKeys += 1;
        UpdateHintKeyText(); // �ؽ�Ʈ ������Ʈ
    }

    // ��Ʈ Ű ���� �ؽ�Ʈ ������Ʈ
    void UpdateHintKeyText()
    {
        hintKeyText.text = hintKeys.ToString(); // TextMeshPro �ؽ�Ʈ ����
    }
}

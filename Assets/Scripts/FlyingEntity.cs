using UnityEngine;

public abstract class FlyingEntity : MonoBehaviour
{
    protected int healthPoints; // ���� ��������
    protected int flightSpeed; // �������� ������

    public abstract void Fly(); // ������ (������ �� �������)
}

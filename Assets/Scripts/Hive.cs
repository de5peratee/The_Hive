using UnityEngine;

public abstract class Hive : StaticObject
{
    private int _integrityPoints; // ����������� ����
    private int _beeCapacity; // ����������� ����
    private int _nectar�apacity; // ����������� �������
    private int _honey�apacity; // ����������� ����
    private int _hiveLevel;

    public void Fix()
    {
        // ����������� �����
    }

    // Start is called before the first frame update
    void Start()
    {
        //_hiveLevel = PlayerPrefs.GetInt("Hive level");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBlink : MonoBehaviour
{
    static float[] Weights = new float[] { 100, 75, 50, 25, 0 };     // 100ʱ�۾�ȫ�գ�0ʱ�۾�ȫ��

    public SkinnedMeshRenderer Face;
    bool m_enable = true;

    bool m_blinking;
    float m_timer;
    int m_index;

    public void Update()
    {
        if (!Face || !Enable)
            return;

        m_timer -= Time.deltaTime;

        if (m_blinking)
        {
            if (m_timer < 0)
            {
                m_timer = 0.05f;                    // ÿ��0.05s����һ��գ�۶������ɵ���գ�۵Ŀ���
                m_index++;

                if (m_index < Weights.Length)
                    SetShape(m_index);              // ����գ�۶������ӱյ���
                else
                {
                    m_blinking = false;             // գ�۽���
                    m_timer = Random.Range(3, 5);   // �����۾�����������ʱ��
                }
            }
        }
        else
        {
            if (m_timer < 0)
                ToBlink();                          // ��ʼգ��
        }
    }

    void ToBlink()
    {
        m_blinking = true;
        m_timer = 0;
        m_index = -1;
    }

    void SetShape(int index)
    {
        Face.SetBlendShapeWeight(13, Weights[index]);
    }

    public bool Enable
    {
        get { return m_enable; }
        set
        {
            if (m_enable != value)
            {
                m_enable = value;

                if (m_enable)
                    ToBlink();
                else
                    SetShape(Weights.Length - 1);
            }
        }
    }
}
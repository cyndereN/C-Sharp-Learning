using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTime : MonoBehaviour
{
    int hour;
    int minute; // �ķ���һ��
    int totalMinute;
    int angle;
    Light myLight;
    GameObject startPartical;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
		//�жϺ�ʼЭ��
		if (!myLight)
		{
            Debug.LogError("�뽫�ű���ӵ�Directional Light��");
		}

        startPartical = GameObject.Find("Start");
        if (!startPartical)
		{
            Debug.LogError("�Ҳ���������Ч");
		}

        StartCoroutine(WaitForTime()); // ����һ��ÿ240sִ��һ�ε�����ѭ��Э�̣�����ʱ�䣬�ı�̫���Ƕ�
    }

    IEnumerator WaitForTime(float time = 240f)
	{
        while (true)
		{
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;

            totalMinute= hour * 60 + minute;
            angle = totalMinute / 4; //4minһ�ȣ�6��0, 0��-90��12��90, 18��180

            transform.rotation = Quaternion.Euler(new Vector3(angle - 90, 0, 0));

            if (angle >= 0 && angle <= 180) // 0-12���ǿ��0-1������ǰ����+90��/180=����ǿ�ȱ���
			{
                myLight.intensity = (angle - 90f + 90f) / 180f;
			}
            if (angle > 180 && angle < 360)
			{
                myLight.intensity = (angle - 90f - 270f) / (-180f);
			}
			//����-90����Ϊ��ƽ�й����ת����ƽ�й��йصĽǶȶ�Ҫ��ȥ90�ȣ���ʱ��ĽǶ�anlge�ǲ��ü�ȥ90�ȵ�
			if ((angle > 290 && angle < 360) || (angle < 90)) //18-6
			{
                startPartical.SetActive(true);
			}
			else
			{
                startPartical.SetActive(false);
            }
            yield return new WaitForSeconds(time);
        }
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

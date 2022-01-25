using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;
using System;

//[System.Serializable]
// class EventVector3 : UnityEvent<Vector3> { }

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance;  // 单例模式
    RaycastHit hitInfo;

    public Texture2D point, doorway, attack, target, arrow;

    private void Awake()
	{
        if (Instance != null)
            Destroy(gameObject);
        Instance = this;
	}


    // public EventVector3 OnMouseClicked;
    public event Action<Vector3> OnMouseClicked;
    public event Action<GameObject> OnEnemyClicked;
    void SetCursorTexture()
	{
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hitInfo))
		{
			// 切换鼠标贴图
			switch (hitInfo.collider.gameObject.tag)
			{
                case "Ground":
                    Cursor.SetCursor(target, new Vector2(16, 16), CursorMode.Auto);
                    break;                
                case "Enemy":
                    Cursor.SetCursor(attack, new Vector2(16, 16), CursorMode.Auto);
                    break;
			}
		}
	}

    void MouseControl()
	{
        if(Input.GetMouseButtonDown(0) && hitInfo.collider != null)
		{
            if (hitInfo.collider.gameObject.CompareTag("Ground"))
                OnMouseClicked?.Invoke(hitInfo.point);
            if (hitInfo.collider.gameObject.CompareTag("Enemy"))
                OnEnemyClicked?.Invoke(hitInfo.collider.gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetCursorTexture();
        MouseControl();
    }
}

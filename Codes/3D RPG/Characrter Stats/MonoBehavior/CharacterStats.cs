using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
	public CharacterData_SO templateData;
	public CharacterData_SO characterData;
	public AttackData_SO attackData;


	[HideInInspector]
	public bool isCritical;

	void Awake()
	{
		if (templateData != null)
			characterData = Instantiate(templateData);
	}

	#region Read from Data_SO
	public int MaxHealth
	{
		get
		{
			if (characterData != null)
				return characterData.maxHealth;
			else return 0;
		}

		set
		{
			characterData.maxHealth = value;  // value是关键字不是变量
		}
	}
	public int CurrentHealth
	{
		get
		{
			if (characterData != null)
				return characterData.currentHealth;
			else return 0;
		}

		set
		{
			characterData.currentHealth = value;  
		}
	}

	public int BaseDefence
	{
		get
		{
			if (characterData != null)
				return characterData.baseDefence;
			else return 0;
		}

		set
		{
			characterData.baseDefence = value;  // value是关键字不是变量
		}
	}
	public int CurrentDefence
	{
		get
		{
			if (characterData != null)
				return characterData.currentDefence;
			else return 0;
		}

		set
		{
			characterData.currentDefence = value;  // value是关键字不是变量
		}
	}
	#endregion

	#region Character Combat

	public void TakeDamage(CharacterStats attacker, CharacterStats defender)
	{
		int damage = Mathf.Max(attacker.CurrentDamage() - defender.CurrentDefence, 0);
		CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
		if (attacker.isCritical)
		{
			defender.GetComponent<Animator>().SetTrigger("Hit");
		}

		//TODO: Update UI，经验
	}

	private int CurrentDamage()
	{
		float coreDamage = Random.Range(attackData.minDamage, attackData.maxDamage);

		if (isCritical)
		{
			coreDamage *= attackData.criticalMultiplier;
			Debug.Log("Critical Damage! " + coreDamage);
		}

		return (int)coreDamage;
	}

	#endregion

}



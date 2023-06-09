using System;
using UnityEngine;

/// <summary>
/// SerializeReference�̍��ڂ�\�����Ă����Editor�g���p�N���X
/// </summary>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class SubclassSelectorAttribute : PropertyAttribute
{
	bool _includeMono;

	public SubclassSelectorAttribute(bool includeMono = false)
	{
		_includeMono = includeMono;
	}

	public bool IsIncludeMono()
	{
		return _includeMono;
	}
}
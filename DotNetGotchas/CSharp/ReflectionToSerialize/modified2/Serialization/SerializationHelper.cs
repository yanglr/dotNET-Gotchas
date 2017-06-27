//SerializationHelper.cs
using System;
using System.Runtime.Serialization;
using System.Reflection;

namespace Serialization
{
	public class SerializationHelper
	{
		public static void SetData(
			Type theType, Object instance, SerializationInfo info)
		{
			SerializationInfoEnumerator enumerator = 
				info.GetEnumerator();

			while(enumerator.MoveNext())
			{
				string fieldName = enumerator.Current.Name;

				FieldInfo theField 
					= theType.GetField(fieldName,
					BindingFlags.Instance | 
					BindingFlags.DeclaredOnly |
					BindingFlags.Public | 
					BindingFlags.NonPublic);
				if (theField != null)
				{
					theField.SetValue(instance, enumerator.Value);
				}
			}
		}

		public static void GetData(
			Type theType, Object instance, SerializationInfo info)
		{
			FieldInfo[] fields = theType.GetFields(
				BindingFlags.Instance | 
				BindingFlags.DeclaredOnly |
				BindingFlags.Public | 
				BindingFlags.NonPublic);

			for(int i = 0; i < fields.Length; i++)
			{
				// Do not serialize NonSerialized fields
				if(!fields[i].IsNotSerialized)
				{
					info.AddValue(fields[i].Name, 
						fields[i].GetValue(instance));
				}
			}
		}
	}
}

﻿using UnityEngine;
using System.Collections.Generic;

namespace Klak.Wiring
{
	[AddComponentMenu("Klak/Wiring/Output/ObjectForward")]
	public class ObjectForward : NodeBase
	{
		#region Editable properties
		[SerializeField]
		Transform _eyeDetect;

		[SerializeField]
		CharacterController _cCon;

		[SerializeField]
		float _distance = 8;
		#endregion

		private Vector3 velocity;
		private Vector3 target;

		#region Node I/O
		[Inlet]
		public float input {
			set {
				Vector3 direction = transform.TransformPoint(_eyeDetect.forward) * value * _distance * Time.deltaTime;
				_cCon.Move (new Vector3 (direction.x, 0.0f, direction.z));

			}
		}
		#endregion

		#region MonoBehaviour functions

		#endregion
	}
}
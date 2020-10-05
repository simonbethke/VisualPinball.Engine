﻿using System;
using Unity.Entities;
using UnityEngine;
using VisualPinball.Engine.Game;
using VisualPinball.Engine.VPT;

namespace VisualPinball.Unity
{
	public abstract class ItemMainAuthoring<TItem, TData> : ItemAuthoring<TItem, TData>,
		IItemMainAuthoring, ILayerableItemAuthoring
		where TItem : Item<TData>, IRenderable
		where TData : ItemData
	{
		/// <summary>
		/// Returns the serialized data.
		/// </summary>
		public override TData Data => _data;

		/// <summary>
		/// Instantiates a new item based on the serialized data, and caches it
		/// for the next access.
		/// </summary>
		public override TItem Item => _item ?? (_item = InstantiateItem(_data));

		/// <summary>
		/// The serialized data, as written to the .vpx file.
		/// </summary>
		///
		/// <remarks>
		/// This might be "empty" (since Unity can't serialize it as `null`), so
		/// the component authoring classes keep a flag whether to read the data
		/// from this field or retrieve it from the parent in the hierarchy.
		/// </remarks>
		[SerializeField]
		private TData _data;

		/// <summary>
		/// The game item object. This is not serialized and gets re-instantiated
		/// and cached here.
		/// </summary>
		[NonSerialized]
		private TItem _item;

		public IItemMainAuthoring SetItem(TItem item, string gameObjectName = null)
		{
			_item = item;
			_data = item.Data;
			name = gameObjectName ?? _data.GetName();
			ItemDataChanged();
			return this;
		}

		/// <summary>
		/// Instantiates a new item based on the item data.
		/// </summary>
		/// <param name="data">Item data</param>
		/// <returns>New item instance</returns>
		protected abstract TItem InstantiateItem(TData data);

		protected void Convert(Entity entity, EntityManager dstManager)
		{
			Item.Index = entity.Index;
			Item.Version = entity.Version;
		}

		protected virtual void OnDrawGizmos()
		{
			// handle dirty whenever scene view draws just in case a field or dependant changed and our
			// custom inspector window isn't up to process it

			// todo rebuild mesh sub components
			// if (_meshDirty) {
			// 	RebuildMeshes();
			// }

			// Draw invisible gizmos over top of the sub meshes of this item so clicking in the scene view
			// selects the item itself first, which is most likely what the user would want
			var mfs = GetComponentsInChildren<MeshFilter>();
			Gizmos.color = Color.clear;
			Gizmos.matrix = Matrix4x4.identity;
			foreach (var mf in mfs) {
				Gizmos.DrawMesh(mf.sharedMesh, mf.transform.position, mf.transform.rotation, mf.transform.lossyScale);
			}
		}


		public virtual ItemDataTransformType EditorPositionType => ItemDataTransformType.None;
		public virtual Vector3 GetEditorPosition() => Vector3.zero;
		public virtual void SetEditorPosition(Vector3 pos) { }

		public virtual ItemDataTransformType EditorRotationType => ItemDataTransformType.None;
		public virtual Vector3 GetEditorRotation() => Vector3.zero;
		public virtual void SetEditorRotation(Vector3 rot) { }

		public virtual ItemDataTransformType EditorScaleType => ItemDataTransformType.None;
		public virtual Vector3 GetEditorScale() => Vector3.zero;
		public virtual void SetEditorScale(Vector3 rot) { }


		public int EditorLayer { get => Data.EditorLayer; set => Data.EditorLayer = value; }
		public string EditorLayerName { get => Data.EditorLayerName; set => Data.EditorLayerName = value; }
		public bool EditorLayerVisibility { get => Data.EditorLayerVisibility; set => Data.EditorLayerVisibility = value; }
	}
}
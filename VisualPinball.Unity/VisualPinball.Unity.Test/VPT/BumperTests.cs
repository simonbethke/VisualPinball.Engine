// Visual Pinball Engine
// Copyright (C) 2021 freezy and VPE Team
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

using System.IO;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using VisualPinball.Engine.Test.Test;
using VisualPinball.Engine.Test.VPT.Bumper;
using VisualPinball.Engine.VPT.Table;
using VisualPinball.Unity.Editor;

namespace VisualPinball.Unity.Test
{
	public class BumperTests
	{
		[Test]
		public void ShouldWriteOriginalBumperData()
		{
			const string tmpFileName = "ShouldWriteBumperData.vpx";
			var go = VpxImportEngine.ImportIntoScene(VpxPath.Bumper);
			var t = go.GetComponent<TableAuthoring>();
			t.TableContainer.Save(tmpFileName);

			var writtenTable = FileTableContainer.Load(tmpFileName);
			BumperDataTests.ValidateTableData(writtenTable.Bumper("Bumper1").Data);

			File.Delete(tmpFileName);
			Object.DestroyImmediate(go);
		}

		[Test]
		public void ShouldWriteUpdatedBumperData()
		{
			const string tmpFileName = "ShouldWriteUpdatedBumperData.vpx";
			var go = VpxImportEngine.ImportIntoScene(VpxPath.Bumper);

			var bumper = go.transform.GetComponentsInChildren<BumperAuthoring>().First(c => c.gameObject.name == "Bumper2");
			var bumperAuth = bumper.GetComponent<BumperAuthoring>();

			bumperAuth.Data.Center.X = 128f;
			bumperAuth.Data.Center.Y = 255f;

			go.GetComponent<TableAuthoring>().TableContainer.Save(tmpFileName);

			var writtenTable = FileTableContainer.Load(tmpFileName);
			var writtenBumperData = writtenTable.Bumper("Bumper2").Data;

			Assert.AreEqual(128f, writtenBumperData.Center.X);
			Assert.AreEqual(255f, writtenBumperData.Center.Y);

			File.Delete(tmpFileName);
			Object.DestroyImmediate(go);
		}

		[Test]
		public void ShouldOnlyImportRing()
		{
			var table = new TableBuilder()
				.AddBumper("Bumper")
				.Build();

			table.Bumper("Bumper").Data.IsBaseVisible = false;
			table.Bumper("Bumper").Data.IsCapVisible = false;
			table.Bumper("Bumper").Data.IsSocketVisible = false;

			var go = VpxImportEngine.ImportIntoScene(table);

			var baseGo = go.transform.Find("Playfield/Bumpers/Bumper/Base");
			var capGo = go.transform.Find("Playfield/Bumpers/Bumper/Cap");
			var socketGo = go.transform.Find("Playfield/Bumpers/Bumper/Skirt");
			var ringGo = go.transform.Find("Playfield/Bumpers/Bumper/Ring");

			Assert.IsFalse(baseGo.GetComponent<BumperBaseMeshAuthoring>().enabled);
			Assert.IsFalse(capGo.GetComponent<BumperCapMeshAuthoring>().enabled);
			Assert.IsFalse(socketGo.GetComponent<BumperSkirtMeshAuthoring>().enabled);
			Assert.IsTrue(ringGo.GetComponent<BumperRingMeshAuthoring>().enabled);

			Object.DestroyImmediate(go);
		}
	}
}
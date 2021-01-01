﻿// Visual Pinball Engine
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

using VisualPinball.Engine.Physics;

namespace VisualPinball.Engine.VPT.Bumper
{
	public class BumperHit : HitCircle
	{
		public BumperHit(BumperData data, float height, IItem item) : base(data.Center, data.Radius, height, height + data.HeightScale, ItemType.Bumper, item)
		{
			FireEvents = data.HitEvent;
			Threshold = data.Threshold;
		}
	}
}

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

using VisualPinball.Engine.Math;

namespace VisualPinball.Engine.VPT.Kicker
{
	public static class KickerHitMesh
	{
		public static readonly Vertex3DNoTex2[] Vertices = {
			new Vertex3DNoTex2( -0.736232f,-0.407777f,-0.070769f, 0.388800f,0.298400f,0.871700f, 0.083212f,0.041577f),
			new Vertex3DNoTex2(  -0.895651f,-0.500504f,0.032088f, 0.388800f,0.298400f,0.871700f, 0.083329f,0.001500f),
			new Vertex3DNoTex2(  -0.736733f,-0.707617f,0.032089f, 0.388800f,0.298400f,0.871700f, 0.124996f,0.001500f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.486800f,0.064100f,0.871200f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,-0.211675f,-0.070769f, -0.486800f,0.064100f,0.871200f, 0.458339f,0.041577f),
			new Vertex3DNoTex2(  0.970374f,-0.000520f,0.032087f, -0.486800f,0.064100f,0.871200f, 0.500000f,0.001500f),
			new Vertex3DNoTex2(  0.936301f,-0.259316f,0.032088f, -0.486800f,0.064100f,0.871200f, 0.458338f,0.001500f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.070769f, -0.453600f,0.187900f,0.871200f, 0.416672f,0.041577f),
			new Vertex3DNoTex2(  0.836399f,-0.500504f,0.032088f, -0.453600f,0.187900f,0.871200f, 0.416671f,0.001500f),
			new Vertex3DNoTex2(  0.936301f,-0.259316f,0.032088f, -0.453600f,0.187900f,0.871200f, 0.458338f,0.001500f),
			new Vertex3DNoTex2(  0.758494f,-0.211675f,-0.070769f, -0.453600f,0.187900f,0.871200f, 0.458339f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.070769f, -0.389500f,0.298900f,0.871200f, 0.416672f,0.041577f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.070769f, -0.389500f,0.298900f,0.871200f, 0.375004f,0.041577f),
			new Vertex3DNoTex2(  0.836399f,-0.500504f,0.032088f, -0.389500f,0.298900f,0.871200f, 0.416671f,0.001500f),
			new Vertex3DNoTex2(  0.677481f,-0.707617f,0.032089f, -0.389500f,0.298900f,0.871200f, 0.375004f,0.001500f),
			new Vertex3DNoTex2(  0.378336f,-0.707122f,-0.070768f, -0.298900f,0.389500f,0.871200f, 0.333336f,0.041577f),
			new Vertex3DNoTex2(  0.470374f,-0.866543f,0.032089f, -0.298900f,0.389500f,0.871200f, 0.333336f,0.001500f),
			new Vertex3DNoTex2(  0.677481f,-0.707617f,0.032089f, -0.298900f,0.389500f,0.871200f, 0.375004f,0.001500f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.070769f, -0.298900f,0.389500f,0.871200f, 0.375004f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,-0.707122f,-0.070768f, -0.187900f,0.453600f,0.871200f, 0.333336f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.070768f, -0.187900f,0.453600f,0.871200f, 0.291668f,0.041577f),
			new Vertex3DNoTex2(  0.470374f,-0.866543f,0.032089f, -0.187900f,0.453600f,0.871200f, 0.333336f,0.001500f),
			new Vertex3DNoTex2(  0.229193f,-0.966445f,0.032089f, -0.187900f,0.453600f,0.871200f, 0.291668f,0.001500f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.070768f, -0.064100f,0.486800f,0.871200f, 0.250000f,0.041577f),
			new Vertex3DNoTex2(  -0.029626f,-1.000520f,0.032089f, -0.064100f,0.486800f,0.871200f, 0.250000f,0.001500f),
			new Vertex3DNoTex2(  0.229193f,-0.966445f,0.032089f, -0.064100f,0.486800f,0.871200f, 0.291668f,0.001500f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.070768f, -0.064100f,0.486800f,0.871200f, 0.291668f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.070768f, 0.064100f,0.486800f,0.871200f, 0.250000f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.070768f, 0.064100f,0.486800f,0.871200f, 0.208332f,0.041577f),
			new Vertex3DNoTex2(  -0.029626f,-1.000520f,0.032089f, 0.064100f,0.486800f,0.871200f, 0.250000f,0.001500f),
			new Vertex3DNoTex2(  -0.288446f,-0.966445f,0.032089f, 0.064100f,0.486800f,0.871200f, 0.208332f,0.001500f),
			new Vertex3DNoTex2(  -0.437585f,-0.707122f,-0.070768f, 0.187900f,0.453600f,0.871200f, 0.166664f,0.041577f),
			new Vertex3DNoTex2(  -0.529626f,-0.866543f,0.032089f, 0.187900f,0.453600f,0.871200f, 0.166664f,0.001500f),
			new Vertex3DNoTex2(  -0.288446f,-0.966445f,0.032089f, 0.187900f,0.453600f,0.871200f, 0.208332f,0.001500f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.070768f, 0.187900f,0.453600f,0.871200f, 0.208332f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,-0.707122f,-0.070768f, 0.298900f,0.389500f,0.871200f, 0.166664f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.070769f, 0.298900f,0.389500f,0.871200f, 0.124996f,0.041577f),
			new Vertex3DNoTex2(  -0.529626f,-0.866543f,0.032089f, 0.298900f,0.389500f,0.871200f, 0.166664f,0.001500f),
			new Vertex3DNoTex2(  -0.736733f,-0.707617f,0.032089f, 0.298900f,0.389500f,0.871200f, 0.124996f,0.001500f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.070769f, 0.390200f,0.298200f,0.871100f, 0.124996f,0.041577f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.070769f, 0.390200f,0.298200f,0.871100f, 0.083212f,0.041577f),
			new Vertex3DNoTex2(  -0.736733f,-0.707617f,0.032089f, 0.390200f,0.298200f,0.871100f, 0.124996f,0.001500f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.070769f, 0.452800f,0.188200f,0.871500f, 0.083212f,0.041577f),
			new Vertex3DNoTex2(  -0.817743f,-0.211675f,-0.070769f, 0.452800f,0.188200f,0.871500f, 0.041661f,0.041577f),
			new Vertex3DNoTex2(  -0.895651f,-0.500504f,0.032088f, 0.452800f,0.188200f,0.871500f, 0.083329f,0.001500f),
			new Vertex3DNoTex2(  -0.895651f,-0.500504f,0.032088f, 0.453600f,0.187900f,0.871200f, 0.083329f,0.001500f),
			new Vertex3DNoTex2(  -0.817743f,-0.211675f,-0.070769f, 0.453600f,0.187900f,0.871200f, 0.041661f,0.041577f),
			new Vertex3DNoTex2(  -0.995552f,-0.259316f,0.032088f, 0.453600f,0.187900f,0.871200f, 0.041662f,0.001500f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.070769f, 0.486800f,0.064100f,0.871200f, 0.000000f,0.041577f),
			new Vertex3DNoTex2(  -0.995552f,-0.259316f,0.032088f, 0.486800f,0.064100f,0.871200f, 0.041662f,0.001500f),
			new Vertex3DNoTex2(  -0.817743f,-0.211675f,-0.070769f, 0.486800f,0.064100f,0.871200f, 0.041661f,0.041577f),
			new Vertex3DNoTex2(  -1.029626f,-0.000520f,0.032087f, 0.486800f,0.064100f,0.871200f, 0.000000f,0.001500f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.327910f, -0.991300f,0.132000f,-0.000000f, 0.500000f,0.120135f),
			new Vertex3DNoTex2(  0.768710f,-0.132618f,-0.327910f, -0.991300f,0.132000f,-0.000000f, 0.473903f,0.120135f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.991300f,0.132000f,-0.000000f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,-0.211675f,-0.070769f, -0.991400f,0.130500f,-0.000000f, 0.458339f,0.041577f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.991400f,0.130500f,-0.000000f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,-0.211677f,-0.327910f, -0.991400f,0.130500f,-0.000000f, 0.458339f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,-0.211677f,-0.327910f, -0.923900f,0.382700f,-0.000000f, 0.458339f,0.120135f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.327909f, -0.923900f,0.382700f,-0.000000f, 0.416672f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,-0.211675f,-0.070769f, -0.923900f,0.382700f,-0.000000f, 0.458339f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.070769f, -0.923900f,0.382700f,-0.000000f, 0.416672f,0.041577f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.327909f, -0.793400f,0.608700f,-0.000000f, 0.375004f,0.120135f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.070769f, -0.793400f,0.608700f,-0.000000f, 0.375004f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.070769f, -0.793400f,0.608700f,-0.000000f, 0.416672f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,-0.408467f,-0.327909f, -0.793400f,0.608700f,-0.000000f, 0.416672f,0.120135f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.327909f, -0.608800f,0.793300f,-0.000000f, 0.375004f,0.120135f),
			new Vertex3DNoTex2(  0.378336f,-0.707125f,-0.327908f, -0.608800f,0.793300f,-0.000000f, 0.333336f,0.120135f),
			new Vertex3DNoTex2(  0.547318f,-0.577454f,-0.070769f, -0.608800f,0.793300f,-0.000000f, 0.375004f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,-0.707122f,-0.070768f, -0.608800f,0.793300f,-0.000000f, 0.333336f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.327908f, -0.382700f,0.923900f,-0.000000f, 0.291668f,0.120135f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.070768f, -0.382700f,0.923900f,-0.000000f, 0.291668f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,-0.707122f,-0.070768f, -0.382700f,0.923900f,-0.000000f, 0.333336f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,-0.707125f,-0.327908f, -0.382700f,0.923900f,-0.000000f, 0.333336f,0.120135f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.327908f, -0.130500f,0.991400f,-0.000000f, 0.291668f,0.120135f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.327908f, -0.130500f,0.991400f,-0.000000f, 0.250000f,0.120135f),
			new Vertex3DNoTex2(  0.181551f,-0.788636f,-0.070768f, -0.130500f,0.991400f,-0.000000f, 0.291668f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.070768f, -0.130500f,0.991400f,-0.000000f, 0.250000f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.327908f, 0.130500f,0.991400f,-0.000000f, 0.208332f,0.120135f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.070768f, 0.130500f,0.991400f,-0.000000f, 0.208332f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.070768f, 0.130500f,0.991400f,-0.000000f, 0.250000f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,-0.816439f,-0.327908f, 0.130500f,0.991400f,-0.000000f, 0.250000f,0.120135f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.327908f, 0.382700f,0.923900f,-0.000000f, 0.208332f,0.120135f),
			new Vertex3DNoTex2(  -0.437585f,-0.707125f,-0.327908f, 0.382700f,0.923900f,-0.000000f, 0.166664f,0.120135f),
			new Vertex3DNoTex2(  -0.240801f,-0.788636f,-0.070768f, 0.382700f,0.923900f,-0.000000f, 0.208332f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,-0.707122f,-0.070768f, 0.382700f,0.923900f,-0.000000f, 0.166664f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.327909f, 0.608800f,0.793300f,-0.000000f, 0.124996f,0.120135f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.070769f, 0.608800f,0.793300f,-0.000000f, 0.124996f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,-0.707122f,-0.070768f, 0.608800f,0.793300f,-0.000000f, 0.166664f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,-0.707125f,-0.327908f, 0.608800f,0.793300f,-0.000000f, 0.166664f,0.120135f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.327909f, 0.794600f,0.607200f,-0.000000f, 0.124996f,0.120135f),
			new Vertex3DNoTex2(  -0.736232f,-0.407779f,-0.327909f, 0.794600f,0.607200f,-0.000000f, 0.083212f,0.120135f),
			new Vertex3DNoTex2(  -0.606567f,-0.577454f,-0.070769f, 0.794600f,0.607200f,-0.000000f, 0.124996f,0.041577f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.147911f, 0.794600f,0.607200f,-0.000000f, 0.083212f,0.059558f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.070769f, 0.794600f,0.607200f,-0.000000f, 0.083212f,0.041577f),
			new Vertex3DNoTex2(  -0.762798f,-0.343866f,-0.147911f, 0.923400f,0.383800f,-0.000000f, 0.069703f,0.059558f),
			new Vertex3DNoTex2(  -0.817743f,-0.211675f,-0.070769f, 0.923400f,0.383800f,-0.000000f, 0.041661f,0.041577f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.070769f, 0.923400f,0.383800f,-0.000000f, 0.083212f,0.041577f),
			new Vertex3DNoTex2(  -0.736232f,-0.407777f,-0.147911f, 0.923400f,0.383800f,-0.000000f, 0.083212f,0.059558f),
			new Vertex3DNoTex2(  -0.817743f,-0.211677f,-0.327910f, 0.923400f,0.383800f,-0.000000f, 0.041661f,0.120135f),
			new Vertex3DNoTex2(  -0.762798f,-0.343866f,-0.327909f, 0.923400f,0.383800f,-0.000000f, 0.069703f,0.120135f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.327910f, 0.991400f,0.130500f,-0.000000f, 0.000000f,0.120135f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.070769f, 0.991400f,0.130500f,-0.000000f, 0.000000f,0.041577f),
			new Vertex3DNoTex2(  -0.817743f,-0.211675f,-0.070769f, 0.991400f,0.130500f,-0.000000f, 0.041661f,0.041577f),
			new Vertex3DNoTex2(  -0.817743f,-0.211677f,-0.327910f, 0.991400f,0.130500f,-0.000000f, 0.041661f,0.120135f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.991800f,0.128200f,0.002000f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.768710f,-0.132618f,-0.327910f, -0.991800f,0.128200f,0.002000f, 0.473903f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,-0.211677f,-0.327910f, -0.991800f,0.128200f,0.002000f, 0.458339f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.486800f,-0.064100f,0.871200f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.486800f,-0.064100f,0.871200f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.936301f,0.258275f,0.032086f, -0.486800f,-0.064100f,0.871200f, 0.541662f,0.001500f),
			new Vertex3DNoTex2(  0.970374f,-0.000520f,0.032087f, -0.486800f,-0.064100f,0.871200f, 0.500000f,0.001500f),
			new Vertex3DNoTex2(  0.836399f,0.499464f,0.032086f, -0.453600f,-0.187900f,0.871200f, 0.583329f,0.001500f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.453600f,-0.187900f,0.871200f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.936301f,0.258275f,0.032086f, -0.453600f,-0.187900f,0.871200f, 0.541662f,0.001500f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.070770f, -0.453600f,-0.187900f,0.871200f, 0.583328f,0.041577f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.070770f, -0.389500f,-0.298900f,0.871200f, 0.624996f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.070770f, -0.389500f,-0.298900f,0.871200f, 0.583328f,0.041577f),
			new Vertex3DNoTex2(  0.677481f,0.706576f,0.032085f, -0.389500f,-0.298900f,0.871200f, 0.624996f,0.001500f),
			new Vertex3DNoTex2(  0.836399f,0.499464f,0.032086f, -0.389500f,-0.298900f,0.871200f, 0.583329f,0.001500f),
			new Vertex3DNoTex2(  0.470374f,0.865500f,0.032085f, -0.298900f,-0.389500f,0.871200f, 0.666664f,0.001500f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.070770f, -0.298900f,-0.389500f,0.871200f, 0.624996f,0.041577f),
			new Vertex3DNoTex2(  0.677481f,0.706576f,0.032085f, -0.298900f,-0.389500f,0.871200f, 0.624996f,0.001500f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.070771f, -0.298900f,-0.389500f,0.871200f, 0.666664f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,0.787595f,-0.070771f, -0.187900f,-0.453600f,0.871200f, 0.708332f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.070771f, -0.187900f,-0.453600f,0.871200f, 0.666664f,0.041577f),
			new Vertex3DNoTex2(  0.229193f,0.965404f,0.032085f, -0.187900f,-0.453600f,0.871200f, 0.708332f,0.001500f),
			new Vertex3DNoTex2(  0.470374f,0.865500f,0.032085f, -0.187900f,-0.453600f,0.871200f, 0.666664f,0.001500f),
			new Vertex3DNoTex2(  -0.029626f,0.999480f,0.032085f, -0.064100f,-0.486800f,0.871200f, 0.750000f,0.001500f),
			new Vertex3DNoTex2(  0.181551f,0.787595f,-0.070771f, -0.064100f,-0.486800f,0.871200f, 0.708332f,0.041577f),
			new Vertex3DNoTex2(  0.229193f,0.965404f,0.032085f, -0.064100f,-0.486800f,0.871200f, 0.708332f,0.001500f),
			new Vertex3DNoTex2(  -0.029625f,0.815398f,-0.070771f, -0.064100f,-0.486800f,0.871200f, 0.750000f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,0.787595f,-0.070771f, 0.064100f,-0.486800f,0.871200f, 0.791668f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,0.815398f,-0.070771f, 0.064100f,-0.486800f,0.871200f, 0.750000f,0.041577f),
			new Vertex3DNoTex2(  -0.288446f,0.965404f,0.032085f, 0.064100f,-0.486800f,0.871200f, 0.791668f,0.001500f),
			new Vertex3DNoTex2(  -0.029626f,0.999480f,0.032085f, 0.064100f,-0.486800f,0.871200f, 0.750000f,0.001500f),
			new Vertex3DNoTex2(  -0.529626f,0.865500f,0.032085f, 0.187900f,-0.453600f,0.871200f, 0.833336f,0.001500f),
			new Vertex3DNoTex2(  -0.240801f,0.787595f,-0.070771f, 0.187900f,-0.453600f,0.871200f, 0.791668f,0.041577f),
			new Vertex3DNoTex2(  -0.288446f,0.965404f,0.032085f, 0.187900f,-0.453600f,0.871200f, 0.791668f,0.001500f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.070771f, 0.187900f,-0.453600f,0.871200f, 0.833336f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.070770f, 0.298900f,-0.389500f,0.871200f, 0.875004f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.070771f, 0.298900f,-0.389500f,0.871200f, 0.833336f,0.041577f),
			new Vertex3DNoTex2(  -0.736733f,0.706576f,0.032085f, 0.298900f,-0.389500f,0.871200f, 0.875004f,0.001500f),
			new Vertex3DNoTex2(  -0.529626f,0.865500f,0.032085f, 0.298900f,-0.389500f,0.871200f, 0.833336f,0.001500f),
			new Vertex3DNoTex2(  -0.895651f,0.499464f,0.032086f, 0.389500f,-0.298900f,0.871200f, 0.916671f,0.001500f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.070770f, 0.389500f,-0.298900f,0.871200f, 0.875004f,0.041577f),
			new Vertex3DNoTex2(  -0.736733f,0.706576f,0.032085f, 0.389500f,-0.298900f,0.871200f, 0.875004f,0.001500f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.070770f, 0.389400f,-0.297500f,0.871700f, 0.916788f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.070770f, 0.389400f,-0.297500f,0.871700f, 0.875004f,0.041577f),
			new Vertex3DNoTex2(  -0.895651f,0.499464f,0.032086f, 0.389400f,-0.297500f,0.871700f, 0.916671f,0.001500f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.070770f, 0.453400f,-0.188500f,0.871100f, 0.958338f,0.041577f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.070770f, 0.453400f,-0.188500f,0.871100f, 0.916788f,0.041577f),
			new Vertex3DNoTex2(  -0.995552f,0.258275f,0.032086f, 0.453400f,-0.188500f,0.871100f, 0.958338f,0.001500f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.070770f, 0.453100f,-0.187700f,0.871500f, 0.916788f,0.041577f),
			new Vertex3DNoTex2(  -0.895651f,0.499464f,0.032086f, 0.453100f,-0.187700f,0.871500f, 0.916671f,0.001500f),
			new Vertex3DNoTex2(  -0.995552f,0.258275f,0.032086f, 0.453100f,-0.187700f,0.871500f, 0.958338f,0.001500f),
			new Vertex3DNoTex2(  -0.995552f,0.258275f,0.032086f, 0.486800f,-0.064100f,0.871200f, 0.958338f,0.001500f),
			new Vertex3DNoTex2(  -1.029626f,-0.000520f,0.032087f, 0.486800f,-0.064100f,0.871200f, 1.000000f,0.001500f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.070770f, 0.486800f,-0.064100f,0.871200f, 0.958338f,0.041577f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.070769f, 0.486800f,-0.064100f,0.871200f, 1.000000f,0.041577f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.327910f, -0.991400f,-0.130500f,0.000000f, 0.500000f,0.120135f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.070769f, -0.991400f,-0.130500f,0.000000f, 0.500000f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.991400f,-0.130500f,0.000000f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.991300f,-0.132000f,0.001200f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.768710f,0.131577f,-0.327910f, -0.991300f,-0.132000f,0.001200f, 0.526097f,0.120135f),
			new Vertex3DNoTex2(  0.786296f,-0.000520f,-0.327910f, -0.991300f,-0.132000f,0.001200f, 0.500000f,0.120135f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.327911f, -0.923900f,-0.382700f,0.000000f, 0.583328f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.327910f, -0.923900f,-0.382700f,0.000000f, 0.541661f,0.120135f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.070770f, -0.923900f,-0.382700f,0.000000f, 0.583328f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.923900f,-0.382700f,0.000000f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.327911f, -0.793400f,-0.608700f,0.000000f, 0.624996f,0.120135f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.327911f, -0.793400f,-0.608700f,0.000000f, 0.583328f,0.120135f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.070770f, -0.793400f,-0.608700f,0.000000f, 0.624996f,0.041577f),
			new Vertex3DNoTex2(  0.676983f,0.407424f,-0.070770f, -0.793400f,-0.608700f,0.000000f, 0.583328f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.327912f, -0.608800f,-0.793300f,0.000000f, 0.666664f,0.120135f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.327911f, -0.608800f,-0.793300f,0.000000f, 0.624996f,0.120135f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.070771f, -0.608800f,-0.793300f,0.000000f, 0.666664f,0.041577f),
			new Vertex3DNoTex2(  0.547318f,0.576411f,-0.070770f, -0.608800f,-0.793300f,0.000000f, 0.624996f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,0.787595f,-0.070771f, -0.382700f,-0.923900f,-0.000000f, 0.708332f,0.041577f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.327912f, -0.382700f,-0.923900f,-0.000000f, 0.666664f,0.120135f),
			new Vertex3DNoTex2(  0.378336f,0.706080f,-0.070771f, -0.382700f,-0.923900f,-0.000000f, 0.666664f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,0.787593f,-0.327912f, -0.382700f,-0.923900f,-0.000000f, 0.708332f,0.120135f),
			new Vertex3DNoTex2(  -0.029625f,0.815396f,-0.327912f, -0.130500f,-0.991400f,0.000000f, 0.750000f,0.120135f),
			new Vertex3DNoTex2(  0.181551f,0.787593f,-0.327912f, -0.130500f,-0.991400f,0.000000f, 0.708332f,0.120135f),
			new Vertex3DNoTex2(  -0.029625f,0.815398f,-0.070771f, -0.130500f,-0.991400f,0.000000f, 0.750000f,0.041577f),
			new Vertex3DNoTex2(  0.181551f,0.787595f,-0.070771f, -0.130500f,-0.991400f,0.000000f, 0.708332f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,0.787595f,-0.070771f, 0.130500f,-0.991400f,0.000000f, 0.791668f,0.041577f),
			new Vertex3DNoTex2(  -0.029625f,0.815396f,-0.327912f, 0.130500f,-0.991400f,0.000000f, 0.750000f,0.120135f),
			new Vertex3DNoTex2(  -0.029625f,0.815398f,-0.070771f, 0.130500f,-0.991400f,0.000000f, 0.750000f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,0.787593f,-0.327912f, 0.130500f,-0.991400f,0.000000f, 0.791668f,0.120135f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.327912f, 0.382700f,-0.923900f,0.000000f, 0.833336f,0.120135f),
			new Vertex3DNoTex2(  -0.240801f,0.787593f,-0.327912f, 0.382700f,-0.923900f,0.000000f, 0.791668f,0.120135f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.070771f, 0.382700f,-0.923900f,0.000000f, 0.833336f,0.041577f),
			new Vertex3DNoTex2(  -0.240801f,0.787595f,-0.070771f, 0.382700f,-0.923900f,0.000000f, 0.791668f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.070770f, 0.608800f,-0.793300f,0.000000f, 0.875004f,0.041577f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.327912f, 0.608800f,-0.793300f,0.000000f, 0.833336f,0.120135f),
			new Vertex3DNoTex2(  -0.437585f,0.706080f,-0.070771f, 0.608800f,-0.793300f,0.000000f, 0.833336f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.327911f, 0.608800f,-0.793300f,0.000000f, 0.875004f,0.120135f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.327911f, 0.794600f,-0.607200f,-0.000000f, 0.916788f,0.120135f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.327911f, 0.794600f,-0.607200f,-0.000000f, 0.875004f,0.120135f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.147913f, 0.794600f,-0.607200f,-0.000000f, 0.916788f,0.059558f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.070770f, 0.794600f,-0.607200f,-0.000000f, 0.916788f,0.041577f),
			new Vertex3DNoTex2(  -0.606567f,0.576411f,-0.070770f, 0.794600f,-0.607200f,-0.000000f, 0.875004f,0.041577f),
			new Vertex3DNoTex2(  -0.762798f,0.342823f,-0.147913f, 0.923400f,-0.383800f,-0.000000f, 0.930297f,0.059558f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.147913f, 0.923400f,-0.383800f,-0.000000f, 0.916788f,0.059558f),
			new Vertex3DNoTex2(  -0.736232f,0.406736f,-0.070770f, 0.923400f,-0.383800f,-0.000000f, 0.916788f,0.041577f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.070770f, 0.923400f,-0.383800f,-0.000000f, 0.958338f,0.041577f),
			new Vertex3DNoTex2(  -0.762798f,0.342823f,-0.327911f, 0.923400f,-0.383800f,-0.000000f, 0.930297f,0.120135f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.327910f, 0.923400f,-0.383800f,-0.000000f, 0.958338f,0.120135f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.327910f, 0.991400f,-0.130500f,0.000000f, 1.000000f,0.120135f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.327910f, 0.991400f,-0.130500f,0.000000f, 0.958338f,0.120135f),
			new Vertex3DNoTex2(  -0.845545f,-0.000520f,-0.070769f, 0.991400f,-0.130500f,0.000000f, 1.000000f,0.041577f),
			new Vertex3DNoTex2(  -0.817743f,0.210634f,-0.070770f, 0.991400f,-0.130500f,0.000000f, 0.958338f,0.041577f),
			new Vertex3DNoTex2(  0.768710f,0.131577f,-0.327910f, -0.991800f,-0.128200f,0.000000f, 0.526097f,0.120135f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.070770f, -0.991800f,-0.128200f,0.000000f, 0.541661f,0.041577f),
			new Vertex3DNoTex2(  0.758494f,0.210634f,-0.327910f, -0.991800f,-0.128200f,0.000000f, 0.541661f,0.120135f)
		};
	}
}

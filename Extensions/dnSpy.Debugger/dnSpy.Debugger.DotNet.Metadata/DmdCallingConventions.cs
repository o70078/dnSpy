﻿/*
    Copyright (C) 2014-2018 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace dnSpy.Debugger.DotNet.Metadata {
	/// <summary>
	/// Calling convention flags
	/// </summary>
	[Flags]
	public enum DmdCallingConventions {
#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
		Standard				= 0x00000001,
		VarArgs					= 0x00000002,
		Any						= 0x00000003,
		HasThis					= 0x00000020,
		ExplicitThis			= 0x00000040,
#pragma warning restore 1591 // Missing XML comment for publicly visible type or member
	}
}

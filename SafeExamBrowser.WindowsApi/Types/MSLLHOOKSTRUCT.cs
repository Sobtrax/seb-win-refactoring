﻿/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Runtime.InteropServices;

namespace SafeExamBrowser.WindowsApi.Types
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct MSLLHOOKSTRUCT
	{
		internal POINT Point;
		internal int MouseData;
		internal int Flags;
		internal int Time;
		internal UIntPtr DwExtraInfo;
	}
}

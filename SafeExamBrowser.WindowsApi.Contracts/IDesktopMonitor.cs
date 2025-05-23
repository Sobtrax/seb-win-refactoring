﻿/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.WindowsApi.Contracts
{
	/// <summary>
	/// Provides funcionality to monitor a desktop, i.e. ensure a given desktop remains active even when a desktop switch is performed.
	/// </summary>
	public interface IDesktopMonitor
	{
		/// <summary>
		/// Starts to monitor the given desktop.
		/// </summary>
		void Start(IDesktop desktop);

		/// <summary>
		/// Stops the monitoring.
		/// </summary>
		void Stop();
	}
}

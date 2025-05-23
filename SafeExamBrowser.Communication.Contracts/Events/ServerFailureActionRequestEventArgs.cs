﻿/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;

namespace SafeExamBrowser.Communication.Contracts.Events
{
	/// <summary>
	/// The event arguments used for the server failure action request event fired by the <see cref="Hosts.IClientHost"/>.
	/// </summary>
	public class ServerFailureActionRequestEventArgs : CommunicationEventArgs
	{
		/// <summary>
		/// The server failure message, if available.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Indicates whether the fallback option should be shown to the user.
		/// </summary>
		public bool ShowFallback { get; set; }

		/// <summary>
		/// Identifies the server failure action selection request.
		/// </summary>
		public Guid RequestId { get; set; }
	}
}

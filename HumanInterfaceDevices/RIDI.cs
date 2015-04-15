﻿using System;

namespace Win32.HumanInterfaceDevices
{
	/// <summary>
	/// Defines the command flag for <see cref="HID.GetRawInputDeviceInfo"/>.
	/// </summary>
	[CLSCompliant(false)]
	public enum RIDI : uint
	{
		/// <summary>
		/// <para><b>pData</b> parameter of <see cref="HID.GetRawInputDeviceInfo"/> points to a string
		/// that contains the device name.</para>
		/// <para>For this <b>uiCommand</b> only, the value in <b>pcbSize</b> of
		/// <see cref="HID.GetRawInputDeviceInfo"/>is the character count (not the byte count).</para>
		/// </summary>
		DEVICENAME=0x20000007,

		/// <summary>
		/// <b>pData</b> parameter of <see cref="HID.GetRawInputDeviceInfo"/> points to an
		/// <see cref="RID_DEVICE_INFO"/> structure.
		/// </summary>
		DEVICEINFO=0x2000000b,

		/// <summary>
		/// <b>pData</b> parameter of <see cref="HID.GetRawInputDeviceInfo"/> points to the previously
		/// parsed data.
		/// </summary>
		PREPARSEDDATA=0x20000005,
	}
}

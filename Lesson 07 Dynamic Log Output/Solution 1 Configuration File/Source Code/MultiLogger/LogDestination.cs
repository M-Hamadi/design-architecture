﻿using System;

namespace Lesson7.Solution1
{

	[Flags]
	public enum LogDestination
	{
		None=0,
		Console=1,
		File=2,
		Both=4,
	}
}

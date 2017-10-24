﻿using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;

namespace Mono.Linker.Tests.Cases.Resources {
	[SetupLinkerCoreAction ("link")]
	[IncludeBlacklistStep (true)]
	[SetupCompileResource ("Dependencies/EmbeddedLinkXmlFileIsNotProcessedIfNameDoesNotMatchAnAssembly.xml", "NotMatchingAnAssemblyName.xml")]
	[SkipPeVerify]
	public class EmbeddedLinkXmlFileIsNotProcessedIfNameDoesNotMatchAnAssembly {
		public static void Main ()
		{
		}

		public class Unused {
		}
	}
}
// Raffie made this!

using UnrealBuildTool;
using System.Collections.Generic;

public class CatCruiseTarget : TargetRules
{
	public CatCruiseTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "CatCruise" } );

    }
}

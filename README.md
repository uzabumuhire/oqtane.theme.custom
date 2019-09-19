# Oqtane Sample Theme

Oqtane allows developers to create custom themes which are rendered by the framework dynamically at run-time.

Currently developers must use the following conventions when creating modules:

- the name of the module folder must be prefixed with "Oqtane.Theme." ( this is required because Blazor generates component namespaces based on folder structure )
- the name of the project file must match the name of theme folder
- the namespace of the optional Theme.cs file ( which implements the ITheme interface ) must match the theme folder

The theme *.csproj file contains PostBuild events. The XCOPY commands need to be updated so that they copy the module DLL to the appropriate folder locations for your Oqtane installation:

  \<Target Name="PostBuild" AfterTargets="PostBuildEvent">
    \<Exec Command="XCOPY &quot;$(TargetDir)Oqtane.Theme.Sample.dll&quot; &quot;**{Your Specific Path Here}**\Oqtane.Server\bin\Debug\netcoreapp3.0\&quot; /S /Y&#xD;&#xA;XCOPY &quot;$(TargetDir)Oqtane.Theme.Sample.dll&quot; &quot;**{Your Specific Path Here}**\Oqtane.Client\bin\Debug\netstandard2.0\dist\_framework\_bin\&quot; /S /Y" />
  \</Target>

A theme can optionally choose to include a theme.cs file which implements the ITheme interface. This interface is used by the framework to load any metadata which is applicable to the theme.

    public class Theme : ITheme
    {
        public string Name { get { return "Sample Theme"; } }
        public string Description { get { return "Sample Theme"; } }
        public string Version { get { return "0.0.1"; } }
        public string Owner { get { return ""; } }
        public string Url { get { return ""; } }
        public string Contact { get { return ""; } }
        public string License { get { return ""; } }
    }



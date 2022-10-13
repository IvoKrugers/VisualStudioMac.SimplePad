using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "SimplePad",
    Namespace = "VisualStudioMac",
    Version = "17.0",
    Category = "IDE extensions"
)]

[assembly: AddinName("SimplePad demo")]
[assembly: AddinDescription("Demo how to create a pad.\n\nby Ivo Krugers")]
[assembly: AddinAuthor("Ivo Krugers")]
[assembly: AddinUrl("https://github.com/IvoKrugers")]

[assembly: AddinDependency("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly: AddinDependency("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]

using System;
using System.IO;

namespace dnGLua.BuildHelper
{
  internal static class Program
  {
    private static void Main(
      bool cleanNuget = false,
      bool cleanPackageHome = false
    )
    {
      if (cleanNuget)
      {
        var up = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var nuget = new DirectoryInfo(Path.Combine(up, ".nuget", "packages"));
        if (nuget.Exists)
        {
          foreach (var dir in nuget.EnumerateDirectories("dnglua.api.*", SearchOption.TopDirectoryOnly))
          {
            Console.WriteLine("Removing directory: {0}", dir.FullName);
            try
            {
              dir.Delete(true);
            }
            catch
            {
              // ignored
            }
          }
        }
      }

      if (cleanPackageHome)
      {
        var packageDir = new DirectoryInfo(Environment.ExpandEnvironmentVariables("%DNGLUA_PACKAGE_HOME%"));
        if (packageDir.Exists)
        {
          Console.WriteLine("Removing directory: {0}", packageDir.FullName);
          try
          {
            packageDir.Delete(true);
          }
          catch
          {
            // ignored
          }
        }
      }
    }
  }
}
using System.Reflection;

namespace PluginPile.Common; 
public static class AssemblyUtil {

  public static Assembly GetAssemblyByName(string name) {
    return AppDomain.CurrentDomain.GetAssemblies().
           Single(assembly => assembly.GetName().Name == name);
  }

  public static Type GetTypeFromAssembly(String assemblyName, String typeName) {
    return GetAssemblyByName(assemblyName).GetType(typeName)!;
  }

  public static MethodInfo GetMethodInfo(String assemblyName, String typeName, String methodName) {
    return GetTypeFromAssembly(assemblyName, typeName).GetMethod(methodName)!;
  }

  public static MethodInfo GetMethodInfo(String assemblyName, String typeName, BindingFlags flags, Func<MethodInfo, bool> predicate) {
    return GetTypeFromAssembly(assemblyName, typeName).GetMethods(flags).Single(predicate);
  }

}

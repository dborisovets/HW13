using NUnit.Framework;

namespace HW13.Data
{
    public static class TestContextValues // class to get values from TestContext
    {
        public static string? ExecutableClassName => TestContext.CurrentContext.Test.ClassName;
    }
}
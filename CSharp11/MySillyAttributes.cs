namespace CSharp11
{
    internal class ParamNameAttribute : Attribute
    {
        public string Name { get; set; }
        public ParamNameAttribute(string name)
        {
            // writing to the console from an attribute is a terrible idea
            Name = name;
        }
    }

   public class TestParamNameAttribute
    {
        public static void Test<T>()
        {
            var type = typeof(T);
            var methods = type.GetMethods();
            var attributes = methods.
                SelectMany(m => m.GetCustomAttributes(true))
                .OfType<ParamNameAttribute>();
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"ParamName: {attribute.Name}");
            }
        }
    }

}

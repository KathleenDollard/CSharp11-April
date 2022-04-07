namespace CSharp11
{
    public class AddNumerics
    {
        [ParamName("values")]
        public static int AddAll(params int[] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));

            int result = 0;
            foreach (var value in values)
            {
                result += value;
            }
            return result;
        }
    }
}

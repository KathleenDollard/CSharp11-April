namespace CSharp11
{
    public class AddNumerics
    {

        // I love it
        // Like the feature, some other syntax
        // don't do the feature now

        [ParamName("values")]
        public static T AddAll<T>(params T[] values!!)
            where T : INumber<T>
        {
            int result = 0;
            foreach (var value in values)
            {
                result += value;
            }
            return result;
        }
    }
}

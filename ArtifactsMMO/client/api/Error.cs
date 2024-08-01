
using ArtifactsMMO.Client.Schema;

namespace ArtifactsMMO.Client.API
{
    public class Error
    {

        private readonly static Dictionary<Type, Exception> errors = new();

        public static Exception getException<T>(Error error)
        {
            var test = errors[typeof(T)];

            return test;
        }
    }
}

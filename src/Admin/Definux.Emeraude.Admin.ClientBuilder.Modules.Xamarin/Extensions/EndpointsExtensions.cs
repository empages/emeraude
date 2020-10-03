using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Definux.Emeraude.Admin.ClientBuilder.Models;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Endpoint"/>.
    /// </summary>
    public static class EndpointsExtensions
    {
        /// <summary>
        /// Get the name of the expected service agent name C# format for the current endpoint.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static string GetServiceAgentExecutionMethod(this Endpoint endpoint)
        {
            string methodName = $"{endpoint.MethodName?.ToLower().ToFirstUpper()}Async";
            List<string> methodGenericParameters = new List<string>();
            string methodArgumentsComma = string.Empty;
            string argumentString = endpoint.ArgumentsListString;
            if (endpoint.Method == HttpMethod.Get)
            {
                methodGenericParameters.Add(endpoint.GetResponseBindableBuildTypeName());
                argumentString = string.Empty;
            }
            else if (endpoint.Method == HttpMethod.Post)
            {
                methodArgumentsComma = ", ";
                if (endpoint.Arguments != null && endpoint.Arguments.Count > 0)
                {
                    methodGenericParameters.Add(endpoint.ComplexArgument?.Class?.Name + "Bindable");
                }
                else
                {
                    argumentString = "null";
                }

                methodGenericParameters.Add(endpoint.GetResponseBindableBuildTypeName());
            }
            else if (endpoint.Method == HttpMethod.Put)
            {
                methodArgumentsComma = ", ";
                if (endpoint.Arguments != null && endpoint.Arguments.Count > 0)
                {
                    methodGenericParameters.Add(endpoint.ComplexArgument?.Class?.Name + "Bindable");
                }
                else
                {
                    argumentString = "null";
                }

                methodGenericParameters.Add(endpoint.GetResponseBindableBuildTypeName());
            }
            else if (endpoint.Method == HttpMethod.Delete)
            {
                methodGenericParameters.Add("HttpStatusCode");
            }

            string result = $"{methodName}<{string.Join(", ", methodGenericParameters)}>($\"{endpoint.Route}\"{methodArgumentsComma}{argumentString})";

            return result;
        }

        /// <summary>
        /// Get response type as a string in C# format for the current endpoint.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static string GetResponseBindableBuildTypeName(this Endpoint endpoint)
        {
            if (endpoint.Response != null)
            {
                if (endpoint.Response.Void)
                {
                    return string.Empty;
                }

                string typeName = endpoint.Response?.Class?.Name + "Bindable";
                if (endpoint.Response.IsCollection)
                {
                    typeName = $"ObservableCollection<{typeName}>";
                }

                return typeName;
            }

            return string.Empty;
        }

        /// <summary>
        /// Get arguments list as a string C# format for the current endpoint.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static string GetBindableStrongTypedArgumentsListString(this Endpoint endpoint)
        {
            if (endpoint.Arguments == null || endpoint.Arguments.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(", ", endpoint.Arguments.Select(x => $"{x.Class.Name}{(x.Class.IsComplex ? "Bindable" : string.Empty)} {x.Name}"));
        }
    }
}

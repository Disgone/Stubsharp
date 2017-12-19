using Stubsharp.Common.Infrastructure;

namespace Stubsharp.Common.Http
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        /// <summary>
        /// Creates an <see cref="ApiResponse{T}"/> from an existing response
        /// </summary>
        /// <param name="response">The response.</param>
        public ApiResponse(IResponse response)
            : this(response, GenerateBody(response))
        {
            
        }

        /// <summary>
        /// Creates an <see cref="ApiResponse{T}"/> from an existing response
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="body">The body.</param>
        public ApiResponse(IResponse response, T body)
        {
            Guard.IsNotNull(response, nameof(response));

            HttpResponse = response;
            Body = body;
        }

        /// <summary>
        /// Gets the deserialized content body.
        /// </summary>
        /// <value>The body.</value>
        public T Body { get; }

        /// <summary>
        /// The raw HTTP response
        /// </summary>
        /// <value>The HTTP response.</value>
        public IResponse HttpResponse { get; private set; }

        private static T GenerateBody(IResponse response)
        {
            return response.Body is T variable ? variable : default( T );
        }
    }
}

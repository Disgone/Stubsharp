using System.Collections.Generic;
using System.Net;

namespace Stubsharp.Common.Http
{
    /// <summary>
    /// A generic HTTP response
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// Gets the response body
        /// </summary>
        /// <value>The body.</value>
        object Body { get; }

        /// <summary>
        /// Gets the response headers.
        /// </summary>
        /// <value>The headers.</value>
        IReadOnlyDictionary<string, string> Headers { get; }

        /// <summary>
        /// Gets the HTTP status code returned.
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Information about the API response parsed from the response headers.
        /// </summary>
        ResponseMetadata Metadata { get; } // This setter is internal for use in tests.
    }
}

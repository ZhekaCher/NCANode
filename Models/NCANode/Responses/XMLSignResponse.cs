// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace NCANode.Models.NCANode.Responses
{
    /// <summary>
    /// Response object for signing XML
    /// </summary>
    public class XMLSignResponse : NCANodeResponse
    {
        /// <summary>
        /// XMLSignResponseResult object
        /// </summary>
        public XMLSignResponseResult result { get; set; }

        /// <summary>
        /// XML.sign response
        /// </summary>
        public class XMLSignResponseResult
        {
            /// <summary>
            /// XML Signed Data
            /// </summary>
            public string xml { get; set; }

            /// <summary>
            /// TSP data (if createTsp = true is specified), in Base64 format
            /// </summary>
            public string tsp { get; set; }
        }
    }
}
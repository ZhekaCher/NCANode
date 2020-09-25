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
    public class XMLSignResponse
    {
        public XMLSignResponseResult result { get; set; }
        public string message { get; set; }
        public int status { get; set; }

        public class XMLSignResponseResult
        {
            public string xml { get; set; }
            public string tsp { get; set; }
        }
    }
}
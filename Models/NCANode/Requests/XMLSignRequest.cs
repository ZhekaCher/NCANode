// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace NCANode.Models.NCANode.Requests
{
    /// <summary>
    /// Request for signing XML
    /// </summary>
    public class XMLSignRequest
    {
        public string version { get; set; } = "1.0";
        public string method { get; set; } = "PKCS12.info";
        public XMLSignRequestParams @params { get; set; }
        public bool createTsp { get; set; } = false;
        public string useTsaPolicy { get; set; }
        public string useTsaPotspHashAlgorithm { get; set; }

        public class XMLSignRequestParams
        {
            public string p12 { get; set; }
            public string password { get; set; }
            public string xml { get; set; }
        }
    }
}
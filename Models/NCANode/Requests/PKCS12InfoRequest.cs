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
    /// Request for getting PKCS12 info
    /// </summary>
    public class PKCS12InfoRequest : NCANodeRequest
    {
        public PKCS12InfoRequest() : base("1.0", "PKCS12.info") {}

        public PKCS12InfoRequestParams @params { get; set; }

        public class PKCS12InfoRequestParams
        {
            /// <summary>
            /// Encoded file with p12 key, in Base64 format
            /// </summary>
            public string p12 { get; set; }
            
            /// <summary>
            /// Key password
            /// </summary>
            public string password { get; set; }
            
            /// <summary>
            /// (optional) Conduct revocation checks via OCSP
            /// </summary>
            public bool verifyOcsp { get; set; } = false;
            
            /// <summary>
            /// (optional) Perform revocation check via CRL
            /// </summary>
            public bool verifyCrl { get; set; } = false;
        }
    }
}
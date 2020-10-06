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
    public class XMLSignRequest : NCANodeRequest
    {
        public XMLSignRequest() : base("1.0", "XML.sign")
        {
        }

        public XMLSignRequestParams @params { get; set; }

        /// <summary>
        /// If true, a TSP tag will be created
        /// </summary>
        public bool createTsp { get; set; } = false;

        /// <summary>
        /// TSP policy indication. Can be one of two parameters:
        /// TSA_GOST_POLICY
        /// TSA_GOSTGT_POLICY
        /// </summary>
        public string useTsaPolicy { get; set; } = TsaPolicy.TSA_GOST_POLICY;

        /// <summary>
        /// Hashing algorithm for generating TSP signature
        /// Can be one of the following values:
        /// MD5
        /// SHA1
        /// SHA224
        /// SHA256
        /// SHA384
        /// SHA512
        /// RIPEMD128
        /// RIPEMD160
        /// RIPEMD256
        /// GOST34311GT
        /// GOST34311
        /// </summary>
        public string useTsaPotspHashAlgorithm { get; set; } = TspHashAlgorithm.GOST34311;

        public class XMLSignRequestParams
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
            /// XML data to be signed
            /// </summary>
            public string xml { get; set; }
        }
    }
}
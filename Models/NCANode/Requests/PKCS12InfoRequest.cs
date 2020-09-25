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
    public class PKCS12InfoRequest
    {
        public string version { get; set; } = "1.0";
        public string method { get; set; } = "PKCS12.info";
        public PKCS12InfoRequestParams @params { get; set; }

        public class PKCS12InfoRequestParams
        {
            public string p12 { get; set; }
            public string password { get; set; }
            public bool verifyOcsp { get; set; } = false;
            public bool verifyCrl { get; set; } = false;
        }
    }
}
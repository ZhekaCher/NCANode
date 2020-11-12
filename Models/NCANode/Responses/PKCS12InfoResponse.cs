// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using System;


namespace NCANode.Models.NCANode.Responses
{
    /// <summary>
    /// Response with PKCS12 info
    /// </summary>
    public class PKCS12InfoResponse : NCANodeResponse
    {
        /// <summary>
        /// PKCS12InfoResponseResult object
        /// </summary>
        public PKCS12InfoResponseResult result { get; set; }

        /// <summary>
        /// PKCS12.info response
        /// </summary>
        /// todo(Add comments)
        public class PKCS12InfoResponseResult
        {
            public bool valid { get; set; }
            public string notAfter { get; set; }
            public PKCS12InfoResponseResult[] chain { get; set; }
            public string keyUsage { get; set; }
            public string serialNumber { get; set; }
            public PKCS12InfoResponseSubject subject { get; set; }
            public string signAlg { get; set; }
            public string sign { get; set; }
            public string publicKey { get; set; }
            public PKCS12InfoResponseIssuer issuer { get; set; }
            public string notBefore { get; set; }
            public string[] keyUser { get; set; }


            public DateTime NotAfter => DateTime.Parse(notAfter);
            public DateTime NotBefore => DateTime.Parse(notBefore);

            public class PKCS12InfoResponseSubject
            {
                public string lastName { get; set; }
                public string country { get; set; }
                public string commonName { get; set; }
                public string gender { get; set; }
                public string surname { get; set; }
                public string locality { get; set; }
                public string dn { get; set; }
                public string state { get; set; }
                public string birthDate { get; set; }
                public string organization { get; set; }
                public string iin { get; set; }
                public long Iin => long.Parse(iin ?? "0");
                public string bin { get; set; }
                public long Bin => long.Parse(bin ?? "0");
            }

            public class PKCS12InfoResponseIssuer
            {
                public string commonName { get; set; }
                public string country { get; set; }
                public string dn { get; set; }
            }
        }
    }
}
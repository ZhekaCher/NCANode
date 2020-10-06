// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
namespace NCANode.Models.NCANode.Requests
{
    /// <summary>
    /// TSA Policies
    /// </summary>
    public static class TsaPolicy
    {
        /// <summary>
        /// GOST new National Certification Center (default)
        /// </summary>
        public const string TSA_GOST_POLICY = "TSA_GOST_POLICY";
        
        /// <summary>
        /// GOST with OID of a current National Certification Center
        /// </summary>
        public const string TSA_GOSTGT_POLICY = "TSA_GOSTGT_POLICY";
    }
}
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace NCANode.Models.NCANode.Requests
{
    public abstract class NCANodeRequest
    {
        /// <summary>
        /// Indicates the version of the API
        /// </summary>
        public string version { get; }
        
        /// <summary>
        /// The name of the method to be executed
        /// </summary>
        public string method { get; }
        
        protected NCANodeRequest(string version, string method)
        {
            this.version = version;
            this.method = method;
        }
        
    }
}
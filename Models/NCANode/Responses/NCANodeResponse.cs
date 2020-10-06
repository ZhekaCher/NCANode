// ReSharper disable InconsistentNaming
namespace NCANode.Models.NCANode.Responses
{
    public class NCANodeResponse
    {
        /// <summary>
        /// request completion message. Empty - if the request is successful
        /// </summary>
        public string message { get; set; }
     
        /// <summary>
        /// execution status, if EQUAL 0 (zero), then everything is fine, otherwise an error occurred
        /// </summary>
        public int status { get; set; }
    }
}
namespace Handlers.Codes
{
    // Derived from Grpc.Core.Api
    /// <summary>
    /// Result of a handler operation
    /// </summary>
    public enum StatusCode
    {
        OK = 0,
        Cancelled = 1,
        Unknown = 2,
        /// <summary>
        /// Client specified invalid argument(s) that are problematic 
        /// regardless of the state of the system
        /// </summary>
        InvalidArgument = 3,
        /// <summary>
        /// Deadline expired before operation could complete. 
        /// </summary>
        DeadlineExceeded = 4,
        NotFound = 5,
        AlreadyExists = 6,
        PermissionDenied = 7,
        /// <summary>
        /// Some resource has been exhausted or the entire system is out of space.
        /// </summary>
        ResourceExhausted = 8,
        /// <summary>
        /// Operation was rejected because the system is not in a state required for the
        /// operation's execution. 
        /// </summary>
        FailedPrecondition = 9,
        Aborted = 10,
        /// <summary>
        /// Operation was attempted past the valid range. E.g. reading past end of data
        /// </summary>        
        OutOfRange = 11,
        Unimplemented = 12,
        /// <summary>
        /// Internal Server Errors
        /// </summary>        
        Internal = 13,
        Unavailable = 14,
        /// <summary>
        /// Unrecoverable data loss or corruption.
        /// </summary>      
        DataLoss = 15,
        Unauthenticated = 16
    }
}

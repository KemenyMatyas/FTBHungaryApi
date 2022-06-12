using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PatientManager.Common.Exceptions
{
    /// <summary>
    /// </summary>
    [Serializable]
    public class BaseException : ApplicationException
    {
        public bool IsLogged { get; set; }
        public int Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public BaseException(string message)
            : base(message)
        {
            IsLogged = false;
            Code = 500;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innenException">The innen exception.</param>
        public BaseException(string message, Exception innenException)
            : base(message, innenException)
        {
            IsLogged = false;
            Code = 500;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseException" /> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="vals">Values</param>
        public BaseException(string message, params object[] vals)
            : base(String.Format(message, vals))
        {
            IsLogged = false;
            Code = 500;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innenException">The innen exception.</param>
        /// <param name="vals">Values</param>
        public BaseException(string message, Exception innenException, params object[] vals)
            : base(String.Format(message, vals), innenException)
        {
            IsLogged = false;
            Code = 500;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BaseException"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="ctxt">The CTXT.</param>
        protected BaseException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            IsLogged = false;
            Code = 500;
        }
    }
}

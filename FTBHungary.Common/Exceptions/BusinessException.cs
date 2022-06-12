using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PatientManager.Common.Exceptions
{
    /// <summary>
    /// Kivétel osztály az üzleti oldalon keletkező hibák kezelésére
    /// </summary>
    [Serializable]
    public class BusinessException : BaseException
    {
        private string[] _args;
        public string[] Args { get { return _args; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPServerNotAvailableException" /> class.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public BusinessException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPServerNotAvailableException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innenException">The innen exception.</param>
        public BusinessException(string message, Exception innenException)
            : base(message, innenException)
        {
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="ASPServerNotAvailableException" /> class.
        ///// </summary>
        ///// <param name="message">A message that describes the error.</param>
        ///// <param name="vals">Values</param>
        //public BusinessException(string message, params object[] vals)
        //    : base(String.Format(message, vals))
        //{

        //}

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPServerNotAvailableException" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args">For exception's data</param>
        public BusinessException(string message, params string[] args) : base(message)
        {
            _args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPServerNotAvailableException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innenException">The innen exception.</param>
        /// <param name="vals">Values</param>
        public BusinessException(string message, Exception innenException, params object[] vals)
            : base(String.Format(message, vals), innenException)
        {
        }        

        /// <summary>
        /// Initializes a new instance of the <see cref="ASPServerNotAvailableException"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="ctxt">The CTXT.</param>
        protected BusinessException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {
            _args = (string[])info.GetValue(nameof(_args), typeof(string[]));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(_args), _args, typeof(string[]));
        }
    }
}
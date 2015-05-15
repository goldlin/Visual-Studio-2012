using System;
using System.Web;

namespace Cryptography_and_Encrypt.Util
{
    public enum DeEncryptStatus
    {
        Ok,
        InvalidFormat,
        Expired
    }

    public class DeEncryptVisitorException : Exception
    {
        public DeEncryptVisitorException(string message)
            : base(message)
        {
        }

        public DeEncryptVisitorException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }

    public class DeEncryptResult
    {
        private readonly DeEncryptStatus _status;
        private readonly Guid _visitorId;

        public DeEncryptResult(DeEncryptStatus status, Guid visitorId)
        {
            _status = status;
            _visitorId = visitorId;
        }

        public DeEncryptResult(DeEncryptStatus status)
        {
            _status = status;
        }

        public DeEncryptStatus Status
        {
            get { return _status; }
        }

        public Guid VisitorId
        {
            get { return _visitorId; }
        }
    }

    public class VisitorEncryptor
    {
        // Fields
        //private static readonly ILog logger = LogManager.GetLogger(typeof(VisitorEncryptor));
        private const string TicketKey = "EUcMAlIdWBSpyAEfMukmZxytMnyZNW8a";

        // Methods
        public static string EncryptVisitorId(Guid visitorId, int minutes)
        {
            //combine visitorid with ticks 
            byte[] contents = new byte[24];
            Array.Copy(visitorId.ToByteArray(), contents, 16);
            Array.Copy(BitConverter.GetBytes(DateTime.Now.AddMinutes(minutes).Ticks), 0, contents, 16, 8);
            //do encryption
            TripleDes des = new TripleDes();
            des.KeyInBase64 = TicketKey;
            string str = Convert.ToBase64String(des.Encrypt(contents));
            //do url encode
            return HttpUtility.UrlEncode(str);
        }

        public static DeEncryptResult DeEncryptVisitorId(string visitorId)
        {
            if (string.IsNullOrEmpty(visitorId))
            {
                //logger.Error("DeEncrypt visitor error", new DeEncryptVisitorException("VisitorId is empty."));
                return new DeEncryptResult(DeEncryptStatus.InvalidFormat);
            }
            try
            {
                TripleDes des = new TripleDes();
                des.KeyInBase64 = TicketKey;
                //decrypt content using triple-des
                byte[] content = des.Decrypt(Convert.FromBase64String(visitorId));
                if (content == null || content.Length != 24)
                {
                    //logger.Error("DeEncrypt visitor error", new DeEncryptVisitorException("VisitorId is in invalid format."));
                    return new DeEncryptResult(DeEncryptStatus.InvalidFormat);
                }
                //validate ticks
                long num = BitConverter.ToInt64(content, 16);
                byte[] guidBytes = new byte[16];
                Array.Copy(content, guidBytes, 16);
                Guid visitor = new Guid(guidBytes);

                if (num < DateTime.Now.Ticks)
                {
                    return new DeEncryptResult(DeEncryptStatus.Expired, visitor);
                }
                //return valid visitoid
                return new DeEncryptResult(DeEncryptStatus.Ok, visitor);
            }
            catch (Exception ex)
            {
                //logger.Error("DeEncrypt visitor error", new DeEncryptVisitorException("DeEncrypt visitor error", ex));
                return new DeEncryptResult(DeEncryptStatus.InvalidFormat);
            }
        }
    }
}

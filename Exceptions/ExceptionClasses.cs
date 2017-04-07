﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EncompassREST.Exceptions
{
    public class FileNotFoundException : Exception
    {
        private string _Data;
        public string ExtraData { get { return _Data; } }
        public FileNotFoundException(string message, string ExtraData) : base(message)
        {
            _Data = ExtraData;

        }
    }



    public class LoanLockedException : RESTException
    {
        
        private Exceptions.LoanLocked _loanLocked;

        public Exceptions.LoanLocked LoanLocked
        {
            get { return _loanLocked; }
        }
        public LoanLockedException(string message, HttpResponseMessage Response) : base(message, Response)
        {
            string value =  Response.Content.ReadAsStringAsync().Result;
            _loanLocked = JsonConvert.DeserializeObject<Exceptions.LoanLocked>(value);
        }

    }

    public class RESTException : Exception
    {
        private HttpResponseMessage _response;
        public HttpStatusCode StatusCode
        {
            get { return _response.StatusCode; }
        }

        public HttpResponseMessage Response
        {
            get { return _response; }
        }

        public string Content
        {
            get { return _response.Content.ReadAsStringAsync().Result; }
        }

        public string correlationID
        {
            get
            {
                var corr = _response.Headers.Where(x => x.Key == "X-Correlation-ID").Select(x => x.Value).FirstOrDefault();
                if (corr != null)
                    return corr.FirstOrDefault();
                else
                    return "NA";
            }
        }


        public RESTException(string message, HttpResponseMessage Response) : base(BaseMessageBuilder(message, Response))
        {
            _response = Response;
        }

        private static string BaseMessageBuilder(string message, HttpResponseMessage Response)
        {
            StringBuilder errorString = new StringBuilder();

            if (message != "")
            {
                errorString.Append(message);
                errorString.Append(Environment.NewLine);
            }

            if (!Response.IsSuccessStatusCode)
            {
                /**/
                HttpError error = Response.Content.ReadAsAsync<HttpError>().Result;
                if (error != null)
                {
                    errorString.Append(error.Message);
                    errorString.Append(Environment.NewLine);

                    if ((error.InnerException != null))
                    {
                        errorString.Append(error.InnerException.Message);
                        errorString.Append(Environment.NewLine);
                    }

                    errorString.Append(error.StackTrace);
                }
                /**/
                //errorString.Append(Response.Content.ReadAsStringAsync().Result);
            }

            return errorString.ToString();
        }
    }

    public class SessionNotOpenException : Exception
    {

    }

    public class InvalidEntitiesException : Exception
    {
        private IEnumerable<string> _entitiesList;

        public IEnumerable<string> InvalidEntitesList
        {
            get { return _entitiesList; }
        }

        public InvalidEntitiesException(IEnumerable<string> EntitesList)
        {
            _entitiesList = EntitesList;
        }
    }
}

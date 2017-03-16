using EncompassREST.Data;
//using EncompassREST.LoanDocs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Documents
    {
        private Loan _loan;
        

        public Session Session
        {
            get { return _loan.Session; }
        }

        public Documents(Loan Loan)
        {
            _loan = Loan;

        }

        public async Task<List<LoanDocs.Document>> getDocumentsListAsync()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents", _loan.encompassId));

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<LoanDocs.Document>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }

        }

        public async Task<LoanDocs.Document> getDocumentAsync(string DocumentID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents/{1}", _loan.encompassId,DocumentID));
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<LoanDocs.Document>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }
        }

        public async Task<List<LoanDocs.Attachment>> getDocumentAttachmentListAsync(string DocumentID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents/{1}/attachments", _loan.encompassId, DocumentID));
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<LoanDocs.Attachment>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }
        }

        public async Task<LoanDocs.Document> postDocumentAsync(string title,string applicationId = "All")
        {
            var newDoc = new
            {
                title = title,
                applicationId = applicationId,
                entityId = 1,
                entityType = "document"
            };
            
            

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("loans/{0}/documents", _loan.encompassId));
            message.Content = new StringContent(JsonConvert.SerializeObject(newDoc), Encoding.UTF32, "application/json");

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                var ID = response.Headers.Location.Segments.Last();
                return await getDocumentAsync(ID);
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }

        }


        public async Task<List<eFolderAttachments.Attachment>> getAttachmentListAsync(Loan loan)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("loans/{0}/attachments", _loan.encompassId));
            var response = await Session.RESTClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var mu = JsonConvert.DeserializeObject<List<eFolderAttachments.Attachment>>(await response.Content.ReadAsStringAsync());
                return mu;
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getAttachmentListAsync", response);
            }
        }



        public async Task<string> getDownloadUrlAsync(eFolderAttachments.Attachment attachment)
        {
            string attachmentID;


            if (attachment.attachmentType == 1)
                attachmentID = attachment.pages.First().zipKey;
            else
                attachmentID = attachment.attachmentId;

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("loans/{0}/attachments/{1}/url", _loan.encompassId,attachmentID));
            var response = await Session.RESTClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var mu = JsonConvert.DeserializeObject<LoanDocs.MediaURL>(await response.Content.ReadAsStringAsync());
                return mu.mediaUrl;
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDownloadUrlAsync", response);
            }
        }

    }
}

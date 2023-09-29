using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Interfaces
{
    public interface IHttpClientCommandHandler
    {
        Task<TRes> DeleteRequest<TRes>(string id) where TRes : class;
        void Dispose();
        Task<TRes> GetRequest<TRes>(string requestUrl) where TRes : class;
        Task<TRes> PostRequest<TRes, TReq>(TReq requestModel, string requestUrl)
            where TRes : class
            where TReq : class;
    }
}

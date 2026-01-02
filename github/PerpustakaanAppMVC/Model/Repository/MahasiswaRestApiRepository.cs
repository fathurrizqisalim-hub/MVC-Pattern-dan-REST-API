using PerpustakaanAppMVC.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanAppMVC.Model.Repository
{
    public class MahasiswaRestApiRepository
    {
        public int Create(Mahasiswa mhs)
        {
            throw new NotImplementedException();
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            var endpoint = "api/mahasiswa";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.POST);
            request.AddJsonBody(mhs);
            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
        }
        public int Update(Mahasiswa mhs)
        {
            throw new NotImplementedException();
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa/NIM";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.PUT);
            var response = client.Execute<List<Mahasiswa>>(request);
            request.AddJsonBody(mhs);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;

        }
        public int Delete(Mahasiswa mhs)
        {
            throw new NotImplementedException();
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa/NIM";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.DELETE);
            var response = client.Execute<List<Mahasiswa>>(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
        }
        public List<Mahasiswa> ReadAll()
        {
            throw new NotImplementedException();
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            var endpoint = "api/mahasiswa";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Mahasiswa>>(request);
            return response.Data;
        }
        public List<Mahasiswa> ReadByNama(string nama)
        {
            throw new NotImplementedException();
            string baseUrl = "http://latihan.coding4ever.net:5555/";
            string endpoint = "api/mahasiswa";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);
            var response = client.Execute<List<Mahasiswa>>(request);

        }
        public Mahasiswa ReadByNpm(string npm)
        {
            throw new NotImplementedException();
        }
    }
}
using CustomerService.Domain.Models;
using Newtonsoft.Json;

namespace CustomerService.Persitence
{
    public class Repository<T> where T : DomainModelBase
    {
        public void Init()
        {
            //Something with chicken/egg issue.
        }

        public T Create()
        {
            return (T)new DomainModelBase();
        }

        public T Read(int id)
        {
            string json = File.ReadAllText("PutHereYourJsonFile.json");

            //Exception handling here?
            //Validations?

            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);

           return list.FirstOrDefault(x => x.Id == id);
        }

        public void Update(T model)
        {
            string json = File.ReadAllText("PutHereYourJsonFile.json");

            //Exception handling here?
            //Validations?

            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);

            var modelToUpdate = list.FirstOrDefault(x => x.Id == (model?.Id ?? -1));

            //Can this be done smarter?

            list.Remove(modelToUpdate);
            list.Add(model);
        }

        public void Delete(int id)
        {
            string json = File.ReadAllText("PutHereYourJsonFile.json");

            //Exception handling here?
            //Validations?

            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);

            var modelToUpdate = list.FirstOrDefault(x => x.Id == id);

            //Can this be done smarter?

            list.Remove(modelToUpdate);
        }

        public List<T> List()
        {
            string json = File.ReadAllText("PutHereYourJsonFile.json");

            //Exception handling here?
            //Validations?

            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
using Models;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DataBase.Repositories
{
    public class SymptomRepository
    {
        private SQLiteConnection _dataBase;

        public SymptomRepository()
        {
            if (_dataBase != null)
                return;

            var dataBasePath = Path.Combine(FileSystem.AppDataDirectory, "DiagnosticApp.db");

            _dataBase = new SQLiteConnection(dataBasePath);

            _dataBase.CreateTable<Symptom>();
        }

        public Symptom GetSymptom(long id)
        {
            var symptom = _dataBase.Table<Symptom>().FirstOrDefault(s => s.Id == id);

            return symptom;
        }

        public IEnumerable<Symptom> GetSymptoms()
        {
            var symptoms = _dataBase.Table<Symptom>().ToList();

            return symptoms;
        }

        public void AddSymptom(Symptom symptom)
        {
            var sections = GetSymptoms();
            var id = sections.Count() + 1;

            symptom.Id = id;

            _dataBase.Insert(symptom);
        }

        public void RemoveSymptom(long id)
        {
            _dataBase.Delete<Symptom>(id);
        }

        public async void RemoveAll()
        {
            _dataBase.DeleteAll<Symptom>();
        }

        ~SymptomRepository()
        {
            _dataBase.Close();
        }
    }
}

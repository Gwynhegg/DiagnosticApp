using Models;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DataBase.Repositories
{
    public class SectionRepository
    {
        private SQLiteConnection _dataBase;

        public SectionRepository()
        {
            if (_dataBase != null)
                return;

            var dataBasePath = Path.Combine(FileSystem.AppDataDirectory, "DiagnosticApp.db");

            _dataBase = new SQLiteConnection(dataBasePath);

            _dataBase.CreateTable<Section>();
        }

        public Section GetSection(long id)
        {
            var section = _dataBase.Table<Section>().FirstOrDefault(c => c.Id == id);

            return section;
        }

        public IEnumerable<Section> GetSections()
        {
            var sections = _dataBase.Table<Section>().ToList();

            return sections;
        }

        public void AddSection(Section section)
        {
            var sections = GetSections();
            var id = sections.Count() + 1;

            section.Id = id;

            _dataBase.Insert(section);
        }

        public void RemoveSection(long id)
        {
            _dataBase.Delete<Section>(id);
        }

        public void RemoveAll()
        {
            _dataBase.DeleteAll<Section>();
        }

        ~SectionRepository()
        {
            _dataBase.Close();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223025.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
           new Mahasiswa("Ragadhitya Janatantra Koeshutama","1302223025", new List<string>{"KPL","PBO" }, 2022),
           new Mahasiswa("Hafid AlAkhyar","1302223044", new List<string>{"KPL","PBO" }, 2022),
           new Mahasiswa("Gina Soraya","1302223070", new List<string>{"KPL","PBO" }, 2022),
           new Mahasiswa("M. Iqbal Nurhaq","1302220096", new List<string>{"KPL","PBO" }, 2022),

        };

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }
        [HttpPost]
        public void post([FromBody]Mahasiswa mmahasiswa)
        {
            mahasiswa.Add(mmahasiswa);
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]
        public void delete(int id) 
        {
            mahasiswa.RemoveAt(id);
        }
    }
}

using B10.Data;
using Microsoft.EntityFrameworkCore;

namespace B10
{
    public class RecnikService
    {
        private readonly RecnikDbContext _context;

        public RecnikService(RecnikDbContext context)
        {
            _context = context;
        }

        public async void DodajPrevod(Prevod p)
        {
            _context.Prevodi.Add(p);
            _context.SaveChanges();
        }

        public Prevod PrevediSrpski(string srpski)
        {
            Prevod prevod = _context.Prevodi.FirstOrDefault(p => p.Srpski == srpski);

            return prevod;
        }

        public Prevod PrevediEngleski(string engleski)
        {
            Prevod prevod = _context.Prevodi.FirstOrDefault(p => p.Engleski == engleski);

            return prevod;
        }
    }
}

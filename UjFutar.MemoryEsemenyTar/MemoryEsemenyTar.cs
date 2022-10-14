using UjFutar.EsemenyTar.Api;

namespace UjFutar.MemoryEsemenyTar;

public class MemoryEsemenyTar : IEsemenyTar
{
    private readonly List<MentettEsemeny> _esemenyek = new();
    public void Ment(IReadOnlyList<Esemeny> esemenyek)
    {
        foreach (var reszletek in esemenyek)
        {
            var esemeny = new MentettEsemeny(
                EsemenyPozicio: new EsemenyPozicio(
                    GlobalisPozicio: (ulong)_esemenyek.Count,
                    Sorszam: (ulong)_esemenyek.Count(e => e.Reszletek.Azonosito == reszletek.Azonosito)),
                RogzitesIdopontja: DateTime.Now,
                Reszletek: reszletek);
            _esemenyek.Add(esemeny);
        }
    }

    public IReadOnlyList<MentettEsemeny> Esemenyek(string azonosito)
    {
        return _esemenyek.Where(e => e.Reszletek.Azonosito == azonosito).ToList();
    }

    public IReadOnlyList<MentettEsemeny> OsszesEsemeny()
    {
        return _esemenyek;
    }
}
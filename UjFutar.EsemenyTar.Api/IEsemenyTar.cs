namespace UjFutar.EsemenyTar.Api;
public interface IEsemenyTar
{
    void Ment(IReadOnlyList<Esemeny> esemenyek);
    IReadOnlyList<MentettEsemeny> Esemenyek(string azonosito);
    IReadOnlyList<MentettEsemeny> OsszesEsemeny();
}
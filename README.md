### Kedves Fejlesztő!

Az Új Futár Kft. product manager-e vagyok. 
A következő feladatban kérem a segítséged:

Cégünk az elkövetkező napokban szeretne a piacra lépni egy új csomagküldő szolgáltatással. Az üzlettől kapott összefoglalót a folyamatokról az alábbi ábrán láthatod.

![Terv](uzleti_terv.jpg?raw=true "Terv")

A feladat a csomagkövetést megvalósító osztály implementálása úgy, hogy az "éles" rendszeren majd az adatok tárolását egyedül az IEsemenyTar interface-t implementáló valamilyen osztály végezze. Ez rendelkezésre áll, tehát ezt nem kell módosítani. A fejlesztéshez a tárolást implementáló csapat adott egy memóriában működő verziót. Ezt a forráskód mellékletében megtalálod.

Módszerünk azon az elgondoláson alapul, hogy ha rögzítjük a csomaggal történt egyes események információit, akkor – az eseménytárból kiolvasva a megadott csomagazonosító összes eseményét – képesek vagyunk rekonstruálni a jelenlegi vagy akár a múlt valamelyik pillanatában az állapotát, helyzetét, egyéb információit.

Kérjük, hogy az átadott git repository-ba folyamatosan, logikai egységenként és érthetően commit-olj.
A készülő kódot tesztekkel támaszd alá.

A feladatra 48 óra áll rendelkezésre. Természetesen nem 48 órát kell vele foglalkoznod, és az sem baj, ha nem érzed 100%-osnak.

Kérjük, hogy abban az állapotban küldd át, ahol tartasz.

A feldat célja, hogy megismerjük a kódolási stílusodat és azt, hogy rá tudsz-e hangolódni egy átlagostól eltérő módszertanra.

Bónusz, ha az alkalmazás: 
 - valamilyen Web API-n elérhető
 - container image build is tartozik hozzá
 - a működése monitorozható külső eszközökkel (pl.: Grafana, Prometheus )


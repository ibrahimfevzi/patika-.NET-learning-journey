+------------------------+             +-----------------------+             +-------------------+
|   HavaYoluŞirketi       |             |      Uçuş              |             |      Pilot        |
+------------------------+             +-----------------------+             +-------------------+
| - kimlik: String       |             | - kimlik: String       |             | - kimlik: String  |
+------------------------+             +-----------------------+             +-------------------+
|                        |             | - havaYoluŞirketi: HavaYoluŞirketi |         +-------------------+
|                        |             | - ucak: Ucak           |             | - deneyimSeviyesi: int |
+------------------------+             +-----------------------+             | - uçakTipi: String |
| + getKimlik(): String  |             | - kalkisHavaalani: Havaalani  |         +-------------------+
| + getUcak(): Ucak      |             | - varisHavaalani: Havaalani   |
| + getUcuslar(): Uçuş[] |             | - kalkisSaati: String  |
+------------------------+             | - varisSaati: String   |
                                       | - pilot: Pilot         |
                                       | - yardimciPilot: Pilot |
                                       +-----------------------+
                                                ^
                                                |
                                       +-----------------------+
                                       |         Ucak          |
                                       +-----------------------+
                                       | - tip: String         |
                                       | - durum: String       |
                                       | - pilotSayisi: int    |
                                       +-----------------------+
                                       | + getTip(): String    |
                                       | + getDurum(): String  |
                                       | + getPilotSayisi(): int |
                                       +-----------------------+
                                                ^
                                                |
                                       +-----------------------+
                                       |      Havaalani        |
                                       +-----------------------+
                                       | - kimlik: String      |
                                       | - isim: String        |
                                       +-----------------------+
                                       | + getKimlik(): String |
                                       | + getIsim(): String   |
                                       +-----------------------+

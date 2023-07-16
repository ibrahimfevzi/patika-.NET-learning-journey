+-----------------------+
| Uygulama |
+-----------------------+
| - filmListesi: Film[] |
+-----------------------+
| + filmListesiniGetir(): Film[] |
| + filmSırala(sıralamaKriteri: Kriter): Film[] |
| + talepEt(filmAdı: String): void |
+-----------------------+
^
|
+-----------------------+
| Kullanıcı |
+-----------------------+
| - kullanıcıAdı: String|
| - abonelik: Abonelik |
| - kredi: int |
+-----------------------+
| + abonelikYap(): void |
| + krediAl(miktar: int): void |
| + filmKiralama(film: Film): void |
| + filmSatınAlma(film: Film): void |
+-----------------------+
^
|
+-----------------------+
| Film |
+-----------------------+
| - filmAdı: String |
| - krediBedeli: int |
| - mevcutDurumu: boolean |
+-----------------------+
| + getFilmAdı(): String |
| + getKrediBedeli(): int|
| + isMevcut(): boolean |
+-----------------------+
^
|
+-----------------------+
| Abonelik |
+-----------------------+
| - abone: Kullanıcı |
| - aktifMi: boolean |
+-----------------------+
| + getAbone(): Kullanıcı|
| + isAktif(): boolean |
+-----------------------+

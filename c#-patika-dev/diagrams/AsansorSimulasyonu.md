+------------------------------------+
| Asansör |
+------------------------------------+
| - kapasite: int |
| - hedefKatlar: List<int> |
| - kat: int |
| - acik: boolean |
| - yon: Yon |
+------------------------------------+
| + yolcuAl(kat: int): void |
| + hedefEkle(kat: int): void |
| + hareketEt(): void |
+------------------------------------+
^
|
+--------------------+
| Kat |
+--------------------+
| - katNo: int |
| - asansorlar: List<Asansör> |
| - varisZili: boolean |
| - sinyalIsigi: boolean |
+--------------------+
| + asansorCagir(yon: Yon): void |
+--------------------+
^
|
+------------------+
| Kapi |
+------------------+
| - acik: boolean |
+------------------+
| + ac(): void |
| + kapat(): void |
+------------------+
^
|
+----------------------+
| KontrolPanel |
+----------------------+
| + hedefDugmesineBas(kat: int): void |
| + kapıAc(): void |
| + kapıKapat(): void |
| + acilDurumDugmesineBas(): void |
+----------------------+
^
|
+----------------------+
| AsansorCagriDugmesi |
+----------------------+
| - yon: Yon |
+----------------------+
| + bas(): void |
+----------------------+
^
|
+----------------------+
| Yolcu |
+----------------------+
| - kalkisKat: int |
| - varisKat: int |
+----------------------+
| + rastgeleYolcuOlustur(): Yolcu |
+----------------------+

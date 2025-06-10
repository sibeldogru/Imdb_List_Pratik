🎬 Proje Adı: IMDb Film Listesi (C# Konsol Uygulaması)

📌 Amaç

Bu C# konsol uygulaması, kullanıcıdan sınırsız sayıda sinema filmi ve IMDb puanı alarak bir liste oluşturur. Ardından bu listeye göre belirli filtrelemeler ve sıralamalar yaparak kullanıcıya anlamlı bilgiler sunar.

🧱 Proje Yapısı
1. Film.cs
Film bilgilerini (isim ve IMDb puanı) tutan basit bir veri sınıfıdır.

2. Program.cs

Konsoldan kullanıcıdan film adı ve puan bilgisi alır.
Kullanıcının e veya h cevabına göre döngüsel giriş sağlar.
Tüm filmleri, belirli puan aralığında olanları ve ismi "A" ile başlayanları filtreleyip listeler.

⚙️ Nasıl Çalışır?

Program çalıştırıldığında kullanıcıdan bir film adı ve IMDb puanı girmesi istenir.
Girilen bilgiler bir Film nesnesine dönüştürülür ve List<Film> koleksiyonuna eklenir.
Kullanıcı yeni bir film girmek isteyip istemediğini belirttikten sonra:
e girerse tekrar giriş yapılır.
h girerse listeleme aşamasına geçilir.

Program şu bilgileri kullanıcıya sunar:
Tüm girilen filmler.
IMDb puanı 4 ile 9 arasında olan filmler.
İsmi "A" harfiyle başlayan filmler.

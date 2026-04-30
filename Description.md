## 🇹🇷 GitHub "About" (Açıklama) Metni
C# ile geliştirilmiş; öğrencilerin notlarını hesaplayan, geçme/kalma durumlarını değerlendiren ve tam kapsamlı CRUD (Ekle, Sil, Güncelle, Listele) özelliklerine sahip interaktif nesne tabanlı konsol uygulaması.

---

## 🚀 Yeni Eklenen Özellikler (Güncellemeler)
- **CRUD İşlemleri (Create, Read, Update, Delete):** Öğrenci ekleme, silme, kimliğe (ID) göre güncelleme ve tüm listeyi görüntüleme özellikleri (`Service` klasöründeki sınıflar ile) eklendi.
- **İnteraktif Konsol Menüsü:** Kullanıcıların kolayca işlem seçebilmesi için kullanıcı dostu bir menü yapısı (`Menu.cs`) entegre edildi.
- **Dinamik Veri Yapısı:** Sadece sabit iki öğrenci yerine, başlangıçta 20 farklı öğrencinin rastgele ID'ler ile tanımlandığı `List<Student>` yapısına geçildi.
- **Modüler Mimari:** Tüm operasyonlar kendi dosyalarına (`AddStudent.cs`, `DeleteStudent.cs`, `ListStudent.cs`, `UpdateStudent.cs`) ayrılarak daha temiz ve nesne yönelimli bir proje yapısı sağlandı.
- **Hata Yönetimi (Error Handling):** Menü seçimlerinde ve girişlerde oluşabilecek hatalı işlemler için kontroller eklendi.

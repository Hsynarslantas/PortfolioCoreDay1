📦 ASP.NET Core MVC Panel Yönetim Projesi
Bu proje, modern web uygulamaları için modüler, dinamik ve bakımı kolay bir yapı oluşturmak amacıyla geliştirilmiştir.
ASP.NET Core MVC mimarisi kullanılarak, dış kaynaktan alınan bir panel yapısı oluşturulmuş ve proje içerisindeki farklı alanlarda rahatlıkla kullanılabilir hale getirilmiştir. 🚀

✨ Proje Özellikleri
🔗 Dış Kaynaktan İçerik: Panel dosyası dışarıdan alınarak wwwroot klasörüne eklenir ve proje içinde kullanıma sunulur.

🛠️ ViewComponent Kullanımı: Panel içerikleri, güçlü bir yapı olan ViewComponent aracılığıyla dinamik bir şekilde uygulamaya entegre edilir.

📄 Statik İçerik Yönetimi: Panel güncellemeleri sadece ilgili statik dosya değiştirilerek kolayca yapılabilir. Kod üzerinde değişiklik yapmaya gerek kalmaz.

♻️ Yeniden Kullanılabilirlik: Aynı panel farklı sayfalarda veya bileşenlerde tekrar tekrar kullanılabilir, bu da kod tekrarını önler.

⚡ Performanslı Yapı: Minimal veri işlemesi ve doğrudan dosya okuma işlemleri ile yüksek performans elde edilir.

🧹 Temiz ve Anlaşılır Kodlama: MVC prensiplerine uygun olarak katmanlı ve okunabilir bir yapı oluşturulmuştur.

🎯 Kolay Bakım ve Gelişim: Proje büyüdükçe yeni paneller veya içerik bölümleri kolayca eklenebilir.

🛠️ Kullanılan Teknolojiler
💻 ASP.NET Core MVC

🧩 ViewComponent yapısı

🖥️ C#

🎨 HTML5, CSS3

🗂️ wwwroot yönetimi

📚 Proje Yapısı
markdown
Kopyala
Düzenle
/wwwroot
    /panels
        panel.html

/ViewComponents
    PanelViewComponent.cs

/Views
    /Shared
        /Components
            /Panel
                Default.cshtml
PanelViewComponent sınıfı içerisinde wwwroot altındaki panel verisi okunur.

Okunan veri, ilgili View'a model olarak gönderilir ve sayfa üzerinde gösterilir.

İçerik değişikliği gerektiğinde yalnızca wwwroot içindeki panel dosyası güncellenir.

🚀 Nasıl Çalışır?
📥 Dışarıdan alınan HTML panel içeriği wwwroot içine eklenir.

🛠️ ViewComponent, dosya içeriğini okur ve View tarafına aktarır.

🖥️ İstediğin view içerisinde ViewComponent çağırılarak panel görüntülenir.

🔄 İçeriği değiştirmek için sadece wwwroot içerisindeki dosyayı güncellemen yeterlidir!

🎯 Neden Bu Yapı?
Bu yapı sayesinde:

Kodda fazlalık olmaz ✅

Panel içerikleri merkezi bir yerden yönetilir ✅

Proje ilerledikçe yeni paneller kolayca entegre edilir ✅

Değişiklikler anlık ve hızlı yapılabilir ✅
![Image](https://github.com/user-attachments/assets/bfd3b1a2-fa58-453d-a35e-d8fd76e6cc1e)

![Image](https://github.com/user-attachments/assets/8ffc82ff-864d-4b47-9dd0-75deec0f3cca)
![Image](https://github.com/user-attachments/assets/cd580cb7-4e90-4175-a996-4601769b27f1)
![Image](https://github.com/user-attachments/assets/4a618e69-fb5f-4e29-b388-ce907776420c)

![Image](https://github.com/user-attachments/assets/7871155f-575d-4d1b-a6a0-dac8e2a70e40)

![Image](https://github.com/user-attachments/assets/8698f4d9-c189-4e19-b8fe-dfbb9f6c8718)
![Image](https://github.com/user-attachments/assets/8625adaf-24d5-4b41-a4c6-b9d4d1104690)
🖥️ Bana Buradan Ulaşabilirsiniz ;
https://github.com/Hsynarslantas/ 

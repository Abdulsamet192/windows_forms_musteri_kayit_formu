# Windows Forms Kullanarak Müşteri Kayıt Formu Oluşturmak
1. [Uygulamanın Amacı](# Uygulamanın Amacı )
2. [Pencereler]()
   - [1. Pencere](# 1. Pencere)
   - [2. Pencere](# 2. Pencere)
   - [3. Pencere](# 3. Pencere)   
3. [Kod Bilgisi](# Şimdi Adım Adım Kodların Nasıl Olmalı)
4. [Tasarım Deseni Nedir?](#tasarım-deseni-nedir)
5. [Tasarım Desenleri](#tasarım-desenleri)
## Uygulamanın Amacı 
Bu projenin tam olarak neden yapıldığını ve içeriğini daha iyi anlamanız için bir tanıtım kısmı yapmayı uygun gördüm. O yüzden bu readme kısmını tanıtım sayfası olarak düşünebilirsiniz.</br> </br> 
## 1. Pencere
İlk olarak projemde neler olmasını istediğimi anlamanız için kafamdaki tasarım fikrini anlatmak ile başlıyorum.Açılan pencerede sol tarafta yeni eklenecek müşterinin bilgilerinin girişlerinin alındığı kutucuklar olacak. Kutuların altında bir adet müşteri kaydını ekle butonu, bir adette kullanıcıları önizle kısmı olacak. Sağ tarafta eklenen kullanıcıların isim ve soyadlarının olduğu üstüne tıklandığı zaman kayıtlarının getirildiği kullanıcı kutusu olacak.</br> </br> 
![Müşteri Bilgileri (3)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/82bef372-5fc7-439b-a97d-f8957a13c04f) </br> </br> 
## 2. Pencere
Kafanızda benim canlandırdığım örnek daha güzel oluşsun diye tasarım programı ile uygulamanın bir önizlemesini yaptım. Şimdiki aşamada ise sağ tarafta kullanıcının bilgilerine daha iyi ulaşılması için ismin üzerine tıklandığında açılacak pencereyi oluşturucam. </br> </br> 
![MÜŞTERİ BİLGİLERİ (3)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/d0bed57b-11f6-4399-bd0e-cfeb4aac40f1) </br> </br> 
## 3. Pencere
Şimdi ise yeni müşteri eklendiğinde ekranda "<em><strong>Yeni Müşteri Eklendi</strong></em>" bildirimini almak istiyorum. Nasıl bir ekran olduğunu anlamanız için yine tasarımı eklicem.
![MÜŞTERİ BİLGİLERİ (5)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/075a505d-32a4-43d6-8ff0-319c582c0fef)</br> </br> 
## Şimdi Adım Adım Kodların Nasıl Olmalı
<strong><ol>
  <li>Yazılım Olarak Ne Kullanacağız?</li>
      <ul>
      <li>Ben uygulamamı tasarlarken <em><strong>Windows Form</strong></em> kullanacağım. Bu yüzden <em><strong>Windows Form</strong></em> hakkında genel çerçevede biraz bilgi vermek istiyorum.  </li>
      <li>Windows Form, Microsoft tarafından geliştirilen bir GUI (Grafik Kullanıcı Arayüzü) uygulama çerçevesidir. Windows Form uygulamaları, Windows işletim sistemi üzerinde çalışan masaüstü uygulamaları için kullanılır.

Windows Form uygulamaları, birçok farklı denetim öğesi (control) içerir. Bu denetim öğeleri, kullanıcının uygulama ile etkileşimde bulunmasını sağlar. Örneğin, butonlar, metin kutuları, listeler, menüler ve diğer birçok denetim öğesi Windows Form uygulamalarında kullanılabilir.

Windows Form uygulamaları, .NET Framework ve C# veya Visual Basic .NET gibi programlama dilleri kullanılarak geliştirilir. Bu uygulamaların geliştirilmesi, kolay bir şekilde tasarlanmış kullanıcı arayüzleri oluşturma, veritabanı işlemleri yapma, verileri depolama ve daha birçok özellik sağlar.

Windows Form, hızlı ve kolay bir şekilde masaüstü uygulamaları geliştirmek için kullanılabilen güçlü bir araçtır.</li>
    </ul>
  <li>Program Olarak Ne Kullanacağız?
  <ul>
      <li>Program olarak ben <em><strong>Microsoft Visual Studio</strong></em> kullandım.</li>
    </ul>
  </li>
  <li>Temel Olarak Kod Mantığı Nasıl Olmalı?
    <ul>
      <li>İlk önce kafamızda neler istediğimizi oturttuk. Şimdi artık iş kod yazma kısmına geldi ve en yorucu kısım burası.</li>
      <li>Görüntü olarak giriş sayfamıza temel elementleri eklemek için </br>
    <code>
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_musteriler;
        private System.Windows.Forms.NotifyIcon bildirimcubugu;
        private System.Windows.Forms.Button button1;</code>
  </br> Bu kod satırlarında, Windows Form uygulamasında bir grup kutusu (group box), buton(button box), yazı kutusu (text box), etiket (label) ve son olarak eklenen verileri görmek için bir liste kutusu (list box) eklemek için kullanılan bir değişken tanımlarıdır. Bunlar kullanıcı arayüzüne başka denetim öğelerini gruplamak için kullanılan bir Windows Forms kontrolüdür. 
  </li>
   <li>Şimdi artık buradaki kutulardan aldığımız verileri bir yere daha sonra kullanmak için depolamalıyız. </br>
    <code>
  internal class sanalDatabase
    {
        public static List<Musteri> musteriler=new List<Musteri>();
    }</code>
  </br> Bu kod bloğu, sanalDatabase adlı bir sınıfı tanımlar ve bu sınıfın içinde, "musteriler" adında bir static List<Musteri> nesnesi tanımlar.

Bu sınıf, bir sanal veritabanı olarak düşünülebilir ve musteriler adlı bu liste, veritabanında yer alan müşteri bilgilerini temsil eder. Liste, program çalışırken tutulan müşteri bilgilerini saklamak için kullanılır ve List<T> sınıfının sağladığı koleksiyon özellikleri ile müşteri bilgileri eklenebilir, çıkarılabilir ve değiştirilebilir.
</li>
   <li>Girilen bilgiler kendileri ile alakalı olan kısımlara değişken atamalarını yaparız. Daha sonra önizleme sayfasında bir veri tabanı mantığı olan listemizden bu verileri çağırıp ekrana yansıtırız.</li>
  <li>Artık temel olarak tüm mantığı oturttuk kodlarımızı yazmaya geçebiliriz.</li>
    </ul>
  </li>
  
</ol></strong>

# Windows Forms Kullanarak Müşteri Kayıt Formu Oluşturmak

### İçindekiler 📄

1. [Uygulamanın Amacı](#uygulamanın-amacı)
2. [Uygulama Videosu](#uygulama-videosu)
3. [Pencereler](.)
   - [1. Pencere](#pencere-1)
   - [2. Pencere](#pencere-2)
   - [3. Pencere](#pencere-3)
4. [Şimdi Adım Adım Kodlar](#şimdi-adım-adım-kodlar)
5. [Yapım Aşaması](#yapım-aşaması)
## Uygulamanın Amacı 
Uygulamamda şirketinizdeki müşterileriniz bilgilerinin tutulduğu ve istenildiği zaman bilgilerin aratılıp bulunduğu bir uygulama geliştirdim. Kısaca içeriğinden bahsedeyim. Uyguluma ilk açıldığında bir yönetim paneli vardır ve bu panelin bir tarafında yeni müşteri eklemek için müşteri bilgilerinin eklendiği form alanları diğer tarafında önceden kayıtlı olan müşterilerin isimlerinin listelendiği bir alan yaptım. Müşteri isimlerinin olduğu kısımdanda isimlerinin üstüne tıklayarak ayrıntılı bir şekilde müşteri bilgilerine ulaşabilirsiniz(telefon numarası, mail, kişisel bilgiler, ihtiyaçlara göre ayrıntılandırılabilir). Yanlış, eksik, farklı format, yeni müşteri eklenecek veya hatalarda uygulamanın sizlere gerekli bildirimleri verdiği uyarı göstergeleri de ekledim. Müşteri eklemek için yeni müşteri ekle butonuna basarak buradan bilgileri doldurup kayıt tuşuna basarak yeni müşterinizi sisteme çok kolay bir şekilde eklemiş oluyorsunuz.   </br> </br> 
## Uygulama Videosu


https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/6c7bc611-c080-48c1-9d7f-d88652816cc6

</br> </br> 
## Pencere 1
İlk olarak projemde neler olmasını istediğimi anlamanız için kafamdaki tasarım fikrini anlatmak ile başlıyorum.Açılan pencerede sol tarafta yeni eklenecek müşterinin bilgilerinin girişlerinin alındığı kutucuklar olacak. Kutuların altında bir adet müşteri kaydını ekle butonu, bir adette kullanıcıları önizle kısmı olacak. Sağ tarafta eklenen kullanıcıların isim ve soyadlarının olduğu üstüne tıklandığı zaman kayıtlarının getirildiği kullanıcı kutusu olacak.</br> </br> 
![Müşteri Bilgileri (3)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/82bef372-5fc7-439b-a97d-f8957a13c04f) </br> </br> 
## Pencere 2
Kafanızda benim canlandırdığım örnek daha güzel oluşsun diye tasarım programı ile uygulamanın bir önizlemesini yaptım. Şimdiki aşamada ise sağ tarafta kullanıcının bilgilerine daha iyi ulaşılması için ismin üzerine tıklandığında açılacak pencereyi oluşturacağım. </br> </br> 
![MÜŞTERİ BİLGİLERİ (3)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/d0bed57b-11f6-4399-bd0e-cfeb4aac40f1) </br> </br> 
## Pencere 3
Şimdi ise yeni müşteri eklendiğinde ekranda "<em><strong>Yeni Müşteri Eklendi</strong></em>" bildirimini almak istiyorum. Nasıl bir ekran olduğunu anlamanız için yine tasarımı ekleyeceğim.
![MÜŞTERİ BİLGİLERİ (5)](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/075a505d-32a4-43d6-8ff0-319c582c0fef)</br> </br> 
## Şimdi Adım Adım Kodlar
<strong><ol>
  <li>Yazılım Dili</li>
      <ul>
      <li>Ben uygulamamı tasarlarken <em><strong>Windows Form</strong></em> kullanacağım. Bu yüzden <em><strong>Windows Form</strong></em> hakkında genel çerçevede biraz bilgi vermek istiyorum.  </li>
      <li>Windows Form, Microsoft tarafından geliştirilen bir GUI (Grafik Kullanıcı Arayüzü) uygulama çerçevesidir. Windows Form uygulamaları, Windows işletim sistemi üzerinde çalışan masaüstü uygulamaları için kullanılır.

Windows Form uygulamaları, birçok farklı denetim öğesi (control) içerir. Bu denetim öğeleri, kullanıcının uygulama ile etkileşimde bulunmasını sağlar. Örneğin, butonlar, metin kutuları, listeler, menüler ve diğer birçok denetim öğesi Windows Form uygulamalarında kullanılabilir.

Windows Form uygulamaları, .NET Framework ve C# veya Visual Basic .NET gibi programlama dilleri kullanılarak geliştirilir. Bu uygulamaların geliştirilmesi, kolay bir şekilde tasarlanmış kullanıcı arayüzleri oluşturma, veritabanı işlemleri yapma, verileri depolama ve daha birçok özellik sağlar.

Windows Form, hızlı ve kolay bir şekilde masaüstü uygulamaları geliştirmek için kullanılabilen güçlü bir araçtır.</li>
    </ul>
  <li>Kullandığım Program
  <ul>
      <li>Program olarak ben <em><strong>Microsoft Visual Studio</strong></em> kullandım.</li>
    </ul>
  </li>
  <li>Temel Olarak Kod Mantığı
    <ul>
      <li>İlk önce kafamızda neler istediğimizi oturttuk. Şimdi artık iş kod yazma kısmına geldi ve en yorucu kısım burası.</li>
      <li>Görüntü olarak giriş sayfamıza temel elementleri eklemek için </br>
Windows Form uygulamasında bir grup kutusu (group box), buton(button box), yazı kutusu (text box), etiket (label) ve son olarak eklenen verileri görmek için bir liste kutusu (list box) eklemek için kullanılan bir değişken tanımlarıdır. Bunlar kullanıcı arayüzüne başka denetim öğelerini gruplamak için kullanılan bir Windows Forms kontrolüdür. 
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
  
</ol></strong> </br>

## Yapım Aşaması
Projede olmasını istediğim ihtiyaçlarımı belirledikten sonra yapım aşamasına geçtim artık. Windows Form ve Visual Studio 2022 projeme başladım. İlk önce form.1 sayfası oluşturarak burada girişteki ekranın içinde olan kutuları(box) ekledim. Bana lazım olanlar;  grup kutusu (group box), buton(button box), yazı kutusu (text box), etiket (label) ve son olarak eklenen verileri görmek için bir liste kutusu (list box) ekledim ve ana ekranda olmasını istediklerim bitti daha sonra ihtiyaca göre bunlar arttırılabilir. Tasarımdan sonra elde ettiğim uygulama görseli aşağıdaki gibidir.</br>
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
        private System.Windows.Forms.Button button1;</code> </br> </br> 
![1](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/d906b9db-421f-493a-b378-cd60c3b439c3) </br>
Göründüğü üzere sağ tarafta müşterilerden istenilen verilerin girişinin yapıldığı kısımları elde ettik, sol tarafta ise kayıt yapıldıktan sonra müşterilerin görüntüleneceği bir ekran elde ettim. Sol altta ise yeni müşteri ekle tuşu ile kullanıcı bilgilerini kaydetme, list box'tan seçilen kaydın önizlemesini görmek içinde bir önizleme butonu elde ettim. </br> 
Paneli elde ettikten sonra artık işin backend kısmının mantığında kullandıklarıma geleyim. Burada farklı iki üç aşama var. Öncelikle girilen bilgilerin bir yerde depolandığı ve istediğimiz zaman veriyi çekebileceğimiz bir veri tabanı lazım bunun için yeni bir belge oluşturup burada bir atama yaparak girilen verileri bir listede topladım. </br> </br>
<code>
       internal class sanalDatabase
    {
        public static List<Musteri> musteriler=new List<Musteri>();
    }
</code> </br>
Bu kod bloğu"sanalDatabase" adında bir sınıf tanımlar. Bu sınıf, bir sanal veritabanı gibi davranarak "musteriler" adında bir Liste nesnesi içerir.
Bu "sanalDatabase" sınıfı, uygulama içindeki müşteri verilerini saklamak ve paylaşmak için kullanılabilir. "musteriler" isimli Liste nesnesi, "Musteri" tipindeki nesneleri depolamak için kullanılır.  </br> 
Ana ekrandaki boc'ların eşleştirmelerini gerekli değişkenlere atadım. Bu sayede alından verileri değişkenleri kullanarak istediğim yerde tekrardan çağırıp kullanabildim.

Şimdi bir uyarı ekranı elde etmek istiyorum bu uyarıyı ise şu mantıkta kullanacağım. Yeni müşteri kaydı yapılırken müşteri ekle butonuna basıldığı zaman ekrana bir uyarı bildirimi gelecek ve "Müşteri eklemek istediğinize emin misiniz?" diye bir bildirim verecek evet veya hayır ile yönlendirme yapacağız. Bunun için Message Box kullandım;</br> 
<code> DialogResult result=MessageBox.Show("Yeni müşteri eklemek istediğinize emin misiniz?","Yeni Müşteri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes) </code>
</br> </br>
![2](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/abb296b9-38a7-46db-970c-1b9eb385f3aa) </br>
Elde ettiğim ekran bu evet denildiğinde hayıt yapılır hayırda ana ekrana geri dönülür. </br> </br>
Müşteri kaydı yapıldıktan sonra ekranın sol tarafındaki list box'ta müşteri adı gözükecek buradan müşteri seçip önizlemeye bastığımızda artık müşterinin bilgilerinin geldiği bir ekran karşımıza çıkacak. </br>
![3](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/6be292c0-dd2e-43ca-8670-eb7b5bd3c317) </br>
Burada bana lazım olan paneli elde etmek için yeniden ana sayfadaki mantığı kullanarak gerekli olan elemanları yeni bir belgede topladım.</br>
![4](https://github.com/Abdulsamet192/windows_forms_musteri_kayit_formu/assets/97125423/2a64761b-24c7-44b0-ae32-ba1c5022ca18)</br>
Daha sonra girilen bilgileri kaydettiğimiz sanal databese'yi kullanarak bilgileri eşleyelek her bilgiyi alakalı kutucuk ile eşleyip verilerin görüşmesini sağladım. Bu sayede girilen her veri kendi alanında yer aldı.</br>
<code>
   internal class Musteri
    {
        public Guid ID { get; set; }        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public override string ToString()
        {
            return Ad +" "+ Soyad ;      
        }
    }
</code> </br>
Bu kod bloğu, "Musteri" adında bir sınıf tanımlar. Bu sınıf, müşteri bilgilerini temsil etmek için kullanılır.</br>
"ID" adında bir "Guid" tipinde bir özellik (property)</br>     
"Ad" adında bir "string" tipinde bir özellik</br>
"Soyad" adında bir "string" tipinde bir özellik</br>
"Email" adında bir "string" tipinde bir özellik</br>
"Telefon" adında bir "string" tipinde bir özellik </br>
Ayrıca, bu sınıfın "ToString" metodunda, "Ad" ve "Soyad" özelliklerini birleştirerek bir metin olarak döndürülmesi sağlanmıştır. Bu, "Musteri" nesnesinin metin temsiline yardımcı olur. </br>

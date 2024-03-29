﻿using m4TR1x.Business.Interfaces;
using m4TR1x.Core.Models;
using m4TR1x.Core.Models.DailyMessageService;
using m4TR1x.Core.Services;
using System;
using System.Collections.Generic;

namespace m4TR1x.Business.Services
{
    public class DailyMessageService : BaseService, IDailyMessageService
    {
        private List<DailyMessageModel> dailyMessages { get; set; }

        public DailyMessageService()
        {

            dailyMessages = new List<DailyMessageModel>
            {

                //001
                new DailyMessageModel("Büyük işletmeler olağanüstü insanlar tarafından değil, sıra dışı şeyler yapan sıradan insanlar tarafından kurulur.",
                                     "Michael Gerber"),
                //002
                new DailyMessageModel("Eğer onu ölçemiyorsanız, değiştiremezsiniz.",
                                 "Peter Drucker"),
                //003
                new DailyMessageModel("Büyüklüğün anahtarı, insanların potansiyelini bulmaya çalışmak ve onu geliştirmek için zaman harcamaktır.",
                                 "Peter Drucker"),
                //004
                new DailyMessageModel("En iyi reklam, memnun müşteriler tarafından yapılır.",
                                 "Philip Kotler"),
                //005
                new DailyMessageModel("Gayretlerimiz tam olarak takdir edildiğinde, her birimiz ortaya daha kaliteli ve daha çok fikir koyabiliriz.",
                                 "Alex F. Osborn"),
                //006
                new DailyMessageModel("Bir süreç olarak ne yaptığınızı tarif edemiyorsanız, ne yaptığınızı bilmiyorsunuz demektir.",
                                 "W. Edwards Deming"),
                //007
                new DailyMessageModel("Dünün yöntemlerini bugünün dünyasında kullanmakta ısrar eden kişi, yarının işinde olmayacaktır.",
                                 "John C. Maxwell"),
                //008
                new DailyMessageModel("Dürüst bir insan daima çocuk kalır.",
                                 "Sokrates"),
                //009
                new DailyMessageModel("Delilik, aynı şeyleri yapıp, farklı sonuçlar beklemektir.",
                                 "Albert Einstein"),
                //010
                new DailyMessageModel("İstediği yere konamayan bir kuş, havada esirdir.",
                                 "Yüksel Yılmaz"),
                //011
                new DailyMessageModel("Devler gibi eserler bırakmak için, karıncalar gibi çalışmak lazım.",
                                 "Necip Fazıl Kısakürek"),
                //012
                new DailyMessageModel("Sözün en güzeli, söyleyenin doğru olarak söylediği, dinleyenin de yararlandığı sözdür.",
                                 "Aristo"),
                //013
                new DailyMessageModel("Önce doğruyu bilmek gerekir. Doğru bilinirse yanlış da bilinir, ama önce yanlış bilinirse, doğruya ulaşılamaz.",
                                 "Fârabî"),
                //014
                new DailyMessageModel("Bir tartışma sırasında, kızdığımız anda gerçek için uğraşmayı bırakır, kendimiz için uğraşmaya başlarız.",
                                 "Goethe"),
                //015
                new DailyMessageModel("Yardım almaya alışan, emir almaya da alışır.",
                                 "Sultan IV. Murad"),
                //016
                new DailyMessageModel("Gömleğin ilk düğmesi yanlış iliklenince, öbürleri de yanlış gider.",
                                 "Ciyordano Bruno"),
                //017
                new DailyMessageModel("İmkanın sınırını görmek için imkansızı denemek lazım.",
                                 "Fatih Sultan Mehmet"),
                //018
                new DailyMessageModel("Doğru yolda giden topal, yoldan sapan çabuk yürüyüşlüyü geçer.",
                                 "Bacon"),
                //019
                new DailyMessageModel("Öğrenmek pahalıdır; ama cehalet çok daha pahalıdır.",
                                 "Henry Clausen"),
                //020
                new DailyMessageModel("Tecrübe herkesin hatalarına verdiği isimdir.",
                                 "Oscar Wilde"),
                //021
                new DailyMessageModel("Her insan, yapmadığı tüm iyiliklerden suçludur.",
                                 "Voltaire"),
                //022
                new DailyMessageModel("Dünyada iki farklı insan var, bilmek isteyenler ve inanmak isteyenler.",
                                 "Friedrich Nietzsche"),
                //023
                new DailyMessageModel("Engelsiz bir yol bulursanız, muhtemelen hiçbir yere gitmez.",
                                 "Frank A. Clark"),
                //024
                new DailyMessageModel("Hayat bir bisiklete binmek gibidir.Dengenizi korumak için hareket etmeye devam etmelisiniz.",
                                 "Albert Einstein"),
                //025
                new DailyMessageModel("Akıl, doldurulacak bir gemi değil, yakılacak bir ateştir.",
                                 "Plutarkhos"),
                //026
                new DailyMessageModel("Dünyayı değiştirmenize gerek yok; kendini değiştirmek zorundasın.",
                                 "Miguel Angel Ruiz"),
                //027
                new DailyMessageModel("Affetmek geçmişi değiştirmez ama geleceğin önünü açar.",
                                 "Paul Boese"),
                //028
                new DailyMessageModel("Hayattan korkmayın çocuklar; iyi ve doğru bir şeyler yaptığınız zaman hayat öyle güzel ki.",
                                 "Dostoyevski"),
                //029
                new DailyMessageModel("Metodu olan topal, metotsuz koşandan daha çabuk ilerler.",
                                 "Francis Bacon"),
                //030
                new DailyMessageModel("Hayat geç kalanları hiç affetmez.",
                                 "Gorbachov"),
                //031
                new DailyMessageModel("Bir araya gelmek bir başlangıçtır, beraberliği sürdürmek bir ilerleme.Beraber çalışmaksa gerçek başarıdır.",
                                 "Henry Ford"),
                //032
                new DailyMessageModel("Bilginin efendisi olmak için çalışmanın uşağı olmak şarttır.",
                                 "Honore de Balzac"),
                //033
                new DailyMessageModel("Planınız bir yıl içinse pirinç ekin, on yıl içinse ağaç dikin, yüz yıl için ise insanları eğitin.",
                                 "Huang Çe"),
                //034
                new DailyMessageModel("İyi kararlar tecrübeden kaynaklanır.Tecrübeler ise kötü kararlardan.",
                                 "Barry LePatner"),
                //035
                new DailyMessageModel("Hakları ve zevkleri ellerinden alınan gençler, onların yerine daha gizli ve tehlikeli olanlarını koyar.",
                                 "Jean Jacques Rousseau"),
                //036
                new DailyMessageModel("Faydasız bir hayat erken bir ölümdür.",
                                 "Johann Wolfgang"),
                //037
                new DailyMessageModel("Öğrenmeye devam eden herkes genç kalır.",
                                 "Henry Ford"),
                //038
                new DailyMessageModel("Kararlarınıza bağlı kalın, ancak yaklaşımınızda esnek kalın.",
                                 "Tony Robbins"),
                //039
                new DailyMessageModel("Kendinizi olumlu insanlarla çevirin.",
                                 "Melanie"),
                //040
                new DailyMessageModel("Arıza bulmayın, bir çare bulun.",
                                 "Henry Ford"),
                //041
                new DailyMessageModel("Uzman, dar bir alanda yapılabilecek tüm hataları yapmış kişiye denir.",
                                 "Niels Bohr"),
                //042
                new DailyMessageModel("Yalnızca bir deli, suyun derinliğini iki ayağıyla anlamaya kalkar.",
                                 "Afrika Atasözü"),
                //043
                new DailyMessageModel("Oyun oynamayı bıraktığımız gün, öğrenmeyi de bırakırız.",
                                "Williams Glasser"),
                //044
                new DailyMessageModel("Zamanı ziyan eden hayatı ziyan eder, zamana sahip çıkan hayata sahip çıkar.",
                                "Alan Lakein"),
                //045
                new DailyMessageModel("Çok fazla hata yaptım ve çok daha fazla hata yapacağım.Bu oyunun bir parçası.Sadece doğru şeylerin yanlış olanları aştığından emin olmalısın.",
                                 "Warren Buffett"),
                //046
                new DailyMessageModel("Birisi bugün gölgede oturuyor çünkü başka biri uzun zaman önce bir ağaç dikti.",
                                 "Warren Buffett"),
                //047
                new DailyMessageModel("Açık bir zihnin olduğu her yerde mutlaka umut olacaktır.",
                                 "Charles F. Kettering"),
                //048
                new DailyMessageModel("Durmadan devam ettiğiniz sürece, ne kadar yavaş gittiğinizin bir önemi yoktur.",
                                 "Konfüçyüs"),
                //049
                new DailyMessageModel("En iyi sakinlikte öğrendiğiniz bazı şeyler vardır, bir de fırtınalı zamanlarda öğrendiğiniz şeyler.",
                                 "Willa Cather"),
                //050
                new DailyMessageModel("Her karmaşık problem için açık, basit ve yanlış bir cevap vardır.",
                                 "H. L. Mencken"),
                //051
                new DailyMessageModel("Bir problemi nasıl çözdüğünüz, hayatınızı nasıl çözdüğünüzü, bir şeyi nasıl yaptığınızsa aslında her şeyi nasıl yaptığınızı gösterir.",
                                 "Steve Chandler"),
                //052
                new DailyMessageModel("Zorunluluklar insana mucizeler yarattırır.",
                                 "José Saramago"),
                //053
                new DailyMessageModel("Vizyon, uygulama olmadan halüsinasyondur.",
                                 "Thomas Edison"),
                //054
                new DailyMessageModel("Müşterilerimin güvenini kaybetmektense, para kaybetmeyi tercih ederim.",
                                 "Robert Bosch"),
                //055
                new DailyMessageModel("Sevginin gücü, güce olan sevgiyi yendiğinde, dünya barışı tanıyacak.",
                                 "Jimi Hendrix"),
                //056
                new DailyMessageModel("Bilgi konuşur, bilge dinler.",
                                 "Jimi Hendrix"),
                //057
                new DailyMessageModel("Bir yanlışı tekrar ediyorsan, artık o bir yanlış değil, karardır.",
                                 "Paulo Coelho"),
                //058
                new DailyMessageModel("Dalından şüphe ettiğin ağacın, gölgesinde soluklanmayacaksın.",
                                 "Paulo Coelho"),
                //059
                new DailyMessageModel("Tam bütün cevapları bulduğunu düşünürsün, sorular değişir.",
                                 "Paulo Coelho"),
                //060
                new DailyMessageModel("İnsan fırsatların gelmesini bekler, fırsatlar da insanın gelmesini. Fırsatlar bekler, insanlar bekler; kazanan hep mazeret olur.",
                                 "Paulo Coelho"),
                //061
                new DailyMessageModel("Bir kere olan bir daha asla tekrarlanmaz. Amma ve lakin iki kere olan mutlaka üçüncü defa da olacaktır.",
                                 "Paulo Coelho"),
                //062
                new DailyMessageModel("Kötü hissetmenin veya yeterince endişelenmenin geçmiş veya gelecekteki bir olayı değiştireceğine inanıyorsanız, Bu, farklı bir gerçeklik sistemiyle başka bir gezegende yaşıyorsunuz demektir.",
                                 "William James"),
                //063
                new DailyMessageModel("Bilge olmak, nelere göz yumulacağını bilmektir.",
                                 "William James"),
                //064
                new DailyMessageModel("Bir seçim yapmanız gerektiğinde; seçmemek de bir seçimdir.",
                                 "William James"),
                //065
                new DailyMessageModel("Birçok insan düşündüğünü sanır, aslında yaptıkları sadece önyargılarını yeniden düzenlemektir.",
                                 "William James"),
                //066
                new DailyMessageModel("İnsan doğasındaki en derin prensip takdir edilme isteğidir.",
                                 "William James"),
                //067
                new DailyMessageModel("Yanlış anlayanlar tarafından söylenen bir doğrudan daha kötü hiçbir yalan yoktur.",
                                 "William James"),
                //068
                new DailyMessageModel("Başkaları için kendinizi unutun o zaman sizi de hatırlayacaklardır.",
                                 "Dostoyevski"),
                //069
                new DailyMessageModel("Sen sana ne sanırsan ayruğa(başkasına) da onu san.",
                                 "Yunus Emre"),
                //070
                new DailyMessageModel("Her insan kendi beyninin heykeltraşıdır.",
                                 "Kajal"),
                //071
                new DailyMessageModel("Sahip olduğunuz tek şey çekiçse, her şey çivi gibi görünmeye başlar.",
                                 "Abraham Maslow"),
                //072
                new DailyMessageModel("Birinci sınıf bir çorba, ikinci sınıf bir tablodan daha yaratıcıdır.",
                                 "Abraham Maslow"),
                //073
                new DailyMessageModel("Eğer bile bile gücünüz yettiğinden daha azını olmayı planlıyorsanız; sizi uyarırım, hayatınızın geri kalan kısmında mutsuz olacaksınız. Kendi yeteneklerinizden ve olanaklarınızdan kaçıyor olacaksınız.",
                                 "Abraham Maslow"),
                //074
                new DailyMessageModel("Oturduğu yerle iftihar eden bir insan görmeyi severim. Sevdiğim diğer bir şey de bir insanın oturduğu yerde kendisiyle iftihar ettirecek şekilde yaşamasıdır.",
                                 "Abraham Maslow"),
                //075
                new DailyMessageModel("Övgünün aldatıcı ve yıkıcı etkisinden kaçmanın tek yolu, çalışmaya devam etmektir.",
                                 "Albert Einstein"),
                //076
                new DailyMessageModel("Özel bir yeteneğim yok fakat tutkulu derecede meraklıyım.",
                                 "Albert Einstein"),
                //077
                new DailyMessageModel("Yeterince gelişmiş, ileri bir teknoloji sihirden farksızdır.",
                                 "Arthur C. Clarke"),
                //078
                new DailyMessageModel("Gelecekle ilgili en iyi tahmin, onu icat etmektir.",
                                 "Alan Kay"),
                //079
                new DailyMessageModel("Konuşmak ucuzdur, bana kodu göster.",
                                 "Linus Torvalds"),
                //080
                new DailyMessageModel("Eğer gerçekler teorinize uymuyorsa gerçekliği değiştirin.",
                                 "Albert Einstein"),
                //081
                new DailyMessageModel("Asla yanlış yapmamış insan, yeni hiç birşey denememiştir.",
                                 "Albert Einstein"),
                //082
                new DailyMessageModel("Mantık sizi A noktasından B noktasına götürür. Hayal gücü her yere.",
                                 "Albert Einstein"),
                //083
                new DailyMessageModel("Mücadele yoksa ilerleme de yoktur.",
                                 "Frederick Douglass"),
                //084
                new DailyMessageModel("Programlamadaki ilerleyişi yazılan kod satırı sayısıyla ölçmek, uçak inşasındaki ilerleyişi ağırlıkla ölçmeye benzer.",
                                 "Bill Gates"),
                //085
                new DailyMessageModel("Ya hatasız kaliteli ürünler üretiriz ya da müşterilerimiz; Bunu başarma yeteneğine sahip başka birini bulurlar.",
                                 "John R. Opel"),
                //086
                new DailyMessageModel("Seni yorgun kılan önündeki tırmanacağın dağ değil, ayakkabındaki çakıl taşıdır.",
                                 "Muhammed Ali"),
                //087
                new DailyMessageModel("Bu ülkedeki herkes bir bilgisayarın nasıl programlanacağını öğrenmeli. Çünkü size nasıl düşünüleceğini öğretiyor.",
                                 "Steve Jobs")
            };
        }

        public DailyMessageModel GetDailyMessage()
        {
            //var firstDayOfYear = new DateTime(DateTime.Now.Year, 1, 1);

            //var firstDayOfYearTicksOffset = firstDayOfYear.Ticks;

            //var NowTicks = DateTime.Now.Ticks - firstDayOfYearTicksOffset;

            //var TotalTicks = firstDayOfYear.AddDays(-1) - firstDayOfYearTicksOffset;

            //var ratio = NowTicks / TotalTicks;

            //ratio = dailyMessages.Count * ratio;

            ////Yılın gününe göre mesaj
            //return dailyMessages.GetRange(ratio, 1).FirstOrDefault;

            var random = new Random();
            return dailyMessages[random.Next(dailyMessages.Count - 1)];
        }

        public override void Dispose(bool disposing)
        {
            dailyMessages.Clear();
        }
    }
}
